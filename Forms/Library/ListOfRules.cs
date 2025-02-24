using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    /// <summary>
    /// Класс набора правил для грамматики
    /// </summary>
    public class ListOfRules
    {
        /// <summary>
        /// Контейнер который хранит в себе списки правил
        /// </summary>
        Dictionary<char, List<Rule>> rules;

        public Dictionary<char, List<Rule>> RuleSets { get { return rules; } }

        /// <summary>
        /// Конструктор простого набора правил
        /// </summary>
        public ListOfRules()
        {
            rules = new Dictionary<char, List<Rule>>();
        }

        /// <summary>
        /// Конструктор набора правил с начальным правилом
        /// </summary>
        /// <param name="rule"> Начальное правило </param>
        public ListOfRules(Rule rule)
        {
            rules = new Dictionary<char, List<Rule>>();
            rules.Add(rule.MainNonTerminal, new List<Rule> { rule });
        }

        /// <summary>
        /// Метод поиска нужного правила
        /// </summary>
        /// <param name="rule"> Искомое правило </param>
        /// <returns> Правда если правило найдено, ложь в обратном случае </returns>
        public bool FindRule(Rule rule)
        {
            foreach (var item in rules)
                if (item.Key == rule.MainNonTerminal)
                {
                    foreach (var element in item.Value)
                        if (element.ConvertedPart == rule.ConvertedPart) return true;
                    return false;
                }
            return false;
        }

        /// <summary>
        /// Метод поиска правила по преобразуемой части
        /// </summary>
        /// <param name="ConvertedPart"> Преобразуемая часть </param>
        /// <returns> Правда если правило было найдено, ложь в обратном случае </returns>
        public bool FindRule(string ConvertedPart)
        {
            foreach(var item in rules)
                foreach (var element in item.Value)
                    if (element.ConvertedPart == ConvertedPart) return true;
            return false;
        }

        /// <summary>
        /// Метод добавления правила в набор правил
        /// </summary>
        /// <param name="rule"> Добавляемое правило </param>
        /// <returns> Правда если правило успешно добавлено, ложь если такое правило уже есть </returns>
        public bool Add(Rule rule) 
        {
            if (FindRule(rule)) return false;
            else if (rules.ContainsKey(rule.MainNonTerminal)) GetRules(rule.MainNonTerminal).Add(rule);
            else rules.Add(rule.MainNonTerminal,new List<Rule> { rule });
            return true;
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedMainNonTerminal"> Новый основной нетерминал </param>
        /// <param name="rule"> Изменяемое правило </param>
        /// <returns> Правда если правило было изменено, ложь в обратном случае </returns>
        public bool Update(char UpdatedMainNonTerminal, Rule rule)
        {
            if (!Delete(rule)) return false;
            Add(new Rule(UpdatedMainNonTerminal, rule.ConvertedPart));
            return true;
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedConvertedPart"> Новая превращаемая строка </param>
        /// <param name="rule"> Изменяемое правило </param>
        /// <returns> Правда если правило было изменено, ложь в обратном случае </returns>
        public bool Update(string UpdatedConvertedPart, Rule rule)
        {
            if (!Delete(rule)) return false;
            Add(new Rule(rule.MainNonTerminal, UpdatedConvertedPart));
            return true;
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedMainNonTerminal"> Новый основной нетерминал </param>
        /// <param name="UpdatedConvertedPart"> Новая превращаемая строка </param>
        /// <param name="rule"> Изменяемое правило </param>
        /// <returns> Правда если правило было изменено, ложь в обратном случае </returns>
        public bool Update(char UpdatedMainNonTerminal, string UpdatedConvertedPart, Rule rule)
        {
            if (!Delete(rule)) return false;
            Add(new Rule(UpdatedMainNonTerminal, UpdatedConvertedPart));
            return true;
        }

        /// <summary>
        /// Метод удаления правила из набора правил
        /// </summary>
        /// <param name="rule"> Правило которое нужно удалить </param>
        /// <returns> Правда если правило удалено, ложь в обратном случае </returns>
        public bool Delete(Rule rule)
        {
            if (!FindRule(rule)) return false;
            int i = 0;
            foreach(var item in rules[rule.MainNonTerminal])
            {
                if(rule.Equals(item))
                {
                    rules[rule.MainNonTerminal].RemoveAt(i);
                    return true;
                }
                i++;
            }
            return false;
        }

        /// <summary>
        /// Метод позволяющий удалить все правила которые содержат указанный символ
        /// </summary>
        /// <param name="Symbol"> Символ по которому удаляются все правила </param>
        /// <returns> Правда если хоть одно правило было удалено, ложь в обратном случае </returns>
        public bool DeleteBySymbol(char Symbol)
        {
            bool result = false;
            foreach (var item in rules)
                if (item.Key.Equals(Symbol))
                {
                    rules.Remove(Symbol);
                    result = true;
                    break;
                }
            foreach (var item in rules)
            {
                int count = item.Value.Count;
                for (int i = 0; i < count; i++)
                {
                    if (item.Value[i].ContainsSymbol(Symbol))
                    {
                        item.Value.RemoveAt(i);
                        result = true;
                        i--;
                        count--;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Метод позволяющий получить все правила по указанному нетерминалу
        /// </summary>
        /// <param name="NonTerminal"> Нетерминал из которого исходят правила </param>
        /// <returns> Список правил </returns>
        public List<Rule> GetRules(char NonTerminal)
        {
            if (rules.Count == 0) return new List<Rule>();
            try {return rules[NonTerminal];}
            catch { return new List<Rule>(); }
        }

        public List<Rule> GetAllRules()
        {
            List<Rule> result = new List<Rule>();
            if (rules.Count == 0) return result;
            foreach(var item in rules.Values)
                foreach(var rule in item)
                    result.Add(rule);
            return result;
        }

        public bool HaveEpsylonRules(char NonTerminal)
        {
            foreach (var rule in GetRules(NonTerminal))
                if (rule.ConvertedPart == "`")
                    return true;
            return false;
        }

        /// <summary>
        /// Метод получения количества подсписков правил
        /// </summary>
        /// <returns> Количество подсписков правил </returns>
        public int Count() { return rules.Count; }

        public override string ToString()
        {
            string result = "";
            foreach (var item in rules)
                foreach (var rule in item.Value)
                    result += rule.ToString() + "\n";
            return result;
        }

        /// <summary>
        /// Метод приведения правил грамматики к виду удобному для преобразования в конечный автомат
        /// </summary>
        /// <param name="non_terminal"> Новый нетерминал который добавляется к правилам вида A -> a </param>
        /// <returns></returns>
        public bool UpdateRulesForNDA(char non_terminal)
        {
            bool result = false;
            while(FindRuleWithSingleTerminal())
            {
                Rule temp = GetRuleWithSingleTerminal();
                Update(temp.ConvertedPart + non_terminal, temp);
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Метод поиска правила с единственным терминалом в правой части
        /// </summary>
        /// <returns></returns>
        Rule GetRuleWithSingleTerminal()
        {
            Rule result = null;
            foreach(var rule in rules)
                foreach(var item in rule.Value)
                    if(item.ConvertedPart.Length == 1 && item.ConvertedPart != "`")
                    {
                        result = item; break;
                    }
            return result;
        }

        bool FindRuleWithSingleTerminal()
        {
            foreach (var rule in rules)
                foreach (var item in rule.Value)
                    if (item.ConvertedPart.Length == 1 && item.ConvertedPart != "`")
                    {
                        return true;
                    }
            return false;
        }
    }
}
