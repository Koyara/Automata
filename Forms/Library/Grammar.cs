using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Forms
{
    /// <summary>
    /// Класс 'Грамматика' который позволяет реализовать порождающую грамматику
    /// </summary>
    public class Grammar
    {
        //стартовый символ грамматики
        char start_symbol;
        //список нетерминалов
        List<char> non_terminals;
        //список терминалов
        List<char> terminals;
        //список правил
        ListOfRules rules;
        //зарезервированный символ для пустого символа
        const char epsylon = '`';

        /// <summary>
        /// Конструктор грамматики с заданием стартового символа
        /// </summary>
        /// <param name="StartSymbol"> Стартовый символ </param>
        public Grammar(char StartSymbol)
        {
            if (StartSymbol == epsylon) start_symbol = '\0';
            else start_symbol = StartSymbol;
            if (start_symbol != '\0') non_terminals = new List<char> { start_symbol };
            else non_terminals = new List<char>();
            terminals = new List<char>();
            rules = new ListOfRules();
        }

        /// <summary>
        /// Конструктор пустой грамматики
        /// </summary>
        public Grammar()
        {
            start_symbol = '\0';
            non_terminals = new List<char> { };
            terminals = new List<char>();
            rules = new ListOfRules();
        }

        /// <summary>
        /// Конструктор грамматики с заданием списка нетерминалов и стартового символа
        /// </summary>
        /// <param name="ListOfNonTerminals"> Список нетерминалов </param>
        /// <param name="StartSymbol"> Стартовый символ </param>
        public Grammar(List<char> ListOfNonTerminals,char StartSymbol)
        {
            if (start_symbol != epsylon)    //проверка если стартовый символ является пустым символом
                start_symbol = StartSymbol;
            else start_symbol = '\0';

            if (ListOfNonTerminals.Contains(epsylon))
            {
                List<char> ListOfNonTerminalsFixed = ListOfNonTerminals;
                ListOfNonTerminalsFixed.Remove(epsylon);
                non_terminals = ListOfNonTerminalsFixed;
            }
            else non_terminals = ListOfNonTerminals;

            if (!non_terminals.Contains(start_symbol) && start_symbol != '\0') { non_terminals.Prepend(StartSymbol); }
            terminals = new List<char>();
            rules = new ListOfRules();
        }

        /// <summary>
        /// Конструктор грамматики с заданием списка нетерминалов, списка терминалов и стартового символа
        /// </summary>
        /// <param name="ListOfNonTerminals"> Список нетерминалов </param>
        /// <param name="ListOfTerminals"> Список терминалов </param>
        /// <param name="StartSymbol"> Стартовый символ </param>
        public Grammar(List<char> ListOfNonTerminals, List<char> ListOfTerminals, char StartSymbol)
        {
            if (start_symbol != epsylon)    //проверка если стартовый символ является пустым символом
                start_symbol = StartSymbol;
            else start_symbol = '\0';
                                                    //проверка если список нетерминалов содержит пустое слово
            if (ListOfNonTerminals.Contains(epsylon))
            {
                List<char> ListOfNonTerminalsFixed = ListOfNonTerminals;
                ListOfNonTerminalsFixed.Remove(epsylon);
                non_terminals = ListOfNonTerminalsFixed;
            }
            else non_terminals = ListOfNonTerminals;

            if (!non_terminals.Contains(start_symbol) && start_symbol != '\0') { non_terminals.Prepend(StartSymbol); }
                                                    //проверка если список терминалов содержит пустое слово
            if (ListOfTerminals.Contains(epsylon))
            {
                List<char> ListOfTerminalsFixed = ListOfTerminals;
                ListOfTerminalsFixed.Remove(epsylon);
                terminals = CheckListsOfSymbols(ListOfTerminalsFixed, ListOfNonTerminals);
            }
            else terminals = CheckListsOfSymbols(ListOfTerminals, ListOfNonTerminals);

            rules = new ListOfRules();
        }

        /// <summary>
        /// Стартовый символ грамматики
        /// </summary>
        public char StartSymbol { get { return start_symbol; } }

        /// <summary>
        /// Список нетерминалов
        /// </summary>
        public List<char> NonTerminals { get { return non_terminals; } }

        /// <summary>
        /// Список терминалов
        /// </summary>
        public List<char> Terminals { get { return terminals; } }

        /// <summary>
        /// Список правил
        /// </summary>
        public ListOfRules Rules { get { return rules; } }

        /// <summary>
        /// Функция установки стартового символа
        /// </summary>
        /// <param name="StartSymbol"> Стартовый символ </param>
        public bool InstallStartSymbol(char StartSymbol)
        {
            if (StartSymbol == epsylon) return false;
            if (terminals.Contains(StartSymbol)) return false;
            if (!non_terminals.Contains(StartSymbol))
                non_terminals.Add(StartSymbol);
            start_symbol = StartSymbol;
            return true;
        }

        /// <summary>
        /// Добавление нетерминала в список нетерминалов
        /// </summary>
        /// <param name="NonTerminal"> Нетреминал </param>
        public bool AddNonTerminal(char NonTerminal)
        {
            if (NonTerminal == epsylon) return false;
            if (non_terminals.Contains(NonTerminal)) return false;
            if (terminals.Contains(NonTerminal)) return false;
            non_terminals.Add(NonTerminal);
            return true;
        }

        /// <summary>
        /// Добавление терминала в список терминалов
        /// </summary>
        /// <param name="Terminal"> Терминал </param>
        public bool AddTerminal(char Terminal)
        {
            if (Terminal == epsylon) return false;
            if (non_terminals.Contains(Terminal)) return false;
            if (terminals.Contains(Terminal)) return false;
            terminals.Add(Terminal);
            return true;
        }

        /// <summary>
        /// Метод сравнения двух списков и удаление элемента из первого списка если он содержится во втором.
        /// </summary>
        /// <param name="TransferFrom"> Список откуда будут удаляться символы </param>
        /// <param name="TransferTo"> Список с которым происходит сравнение </param>
        /// <returns> Итоговый преобразованный список </returns>
        List<char> CheckListsOfSymbols(List<char> TransferFrom, List<char> TransferTo)
        {
            foreach(char symbol in TransferFrom)
                if(TransferTo.Contains(symbol))
                    TransferFrom.Remove(symbol);
            return TransferFrom;
        }

        /// <summary>
        /// Метод удаления эпсилон-символов в строке
        /// </summary>
        /// <param name="Str"> Строка из которой нужно удалить эпсилон-символы </param>
        /// <returns> Строка без эпсилон-символов </returns>
        string DeleteEpsylons(string Str)
        {
            for (int i = 0; i < Str.Length; i++)
                if (Str[i] == epsylon)
                {
                    Str = Str.Remove(i,1);
                    i--;
                    if (Str.Length == 0)
                        return "`";
                }
            return Str;
        }

        /// <summary>
        /// Метод добавления правила в набор правил грамматики
        /// </summary>
        /// <param name="MainNonTerminal"> Нетерминал из которого исходит правило </param>
        /// <param name="ConvertedPart"> Строка в которую превращается нетерминал </param>
        /// <returns> Правда если правило добавлено, ложь если хотя бы одного из символов нет в списках грамматики </returns>
        public bool AddRule(char MainNonTerminal, string ConvertedPart)
        {
            if(!non_terminals.Contains(MainNonTerminal)) return false;
            if(ConvertedPart == "") return false;
            if (ConvertedPart != "`")
            {
                foreach (char symbol in ConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (ConvertedPart.Contains("`"))
                    ConvertedPart = DeleteEpsylons(ConvertedPart);
            }
            rules.Add(new Rule(MainNonTerminal, ConvertedPart));
            return true;
        }

        /// <summary>
        /// Метод добавления правила в набор правил грамматики
        /// </summary>
        /// <param name="rule"> Добавляемое правило типа Rule </param>
        /// <returns>Правда если правило добавлено, ложь если хотя бы одного из символов нет в списках грамматики </returns>
        public bool AddRule(Rule rule)
        {
            if (!non_terminals.Contains(rule.MainNonTerminal)) return false;
            if (rule.ConvertedPart == "") return false;
            if(rule.ConvertedPart == "`")
            {
                foreach (char symbol in rule.ConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (rule.ConvertedPart.Contains("`"))
                    rule.ConvertedPart = DeleteEpsylons(rule.ConvertedPart);
            }    
            rules.Add(rule);
            return true;
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedMainNonTerminal"> Изменённый основной нетерминал правила </param>
        /// <param name="rule"> Правило которое изменяется </param>
        /// <returns> Правда если изменение успешно, ложь в обратном случае </returns>
        public bool UpdateRule(char UpdatedMainNonTerminal, Rule rule)
        {
            if (!non_terminals.Contains(rule.MainNonTerminal)) return false;
            if(rule.ConvertedPart != "`")
            {
                foreach (char symbol in rule.ConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (rule.ConvertedPart.Contains("`"))
                    rule.ConvertedPart = DeleteEpsylons(rule.ConvertedPart);
            }
            if (!non_terminals.Contains(UpdatedMainNonTerminal)) return false;
            return rules.Update(UpdatedMainNonTerminal, rule);
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedMainNonTerminal"> Изменённый основной нетерминал правила </param>
        /// <param name="NonTerminalOfRule"> Нетерминал изменяемого правила </param>
        /// <param name="ConvertedPartOfRule"> Строка правила в которую превращается нетерминал</param>
        /// <returns> Правда если изменение успешно, ложь в обратном случае </returns>
        public bool UpdateRule(char UpdatedMainNonTerminal, char NonTerminalOfRule, string ConvertedPartOfRule)
        {
            if (!non_terminals.Contains(NonTerminalOfRule)) return false;
            if(ConvertedPartOfRule != "`")
            {
                foreach (char symbol in ConvertedPartOfRule)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (ConvertedPartOfRule.Contains("`"))
                    ConvertedPartOfRule = DeleteEpsylons(ConvertedPartOfRule);
            }
            if (!non_terminals.Contains(UpdatedMainNonTerminal)) return false;
            return rules.Update(UpdatedMainNonTerminal, new Rule(NonTerminalOfRule,ConvertedPartOfRule));
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedConvertedPart"> Изменённая строка превращения </param>
        /// <param name="rule"> Изменяемое правило </param>
        /// <returns> Правда если изменение успешно, ложь в обратном случае </returns>
        public bool UpdateRule(string UpdatedConvertedPart, Rule rule)
        {
            if (!non_terminals.Contains(rule.MainNonTerminal)) return false;
            if(rule.ConvertedPart != "`")
            {
                foreach (char symbol in rule.ConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (rule.ConvertedPart.Contains("`"))
                    rule.ConvertedPart = DeleteEpsylons(rule.ConvertedPart);
            }

            if(UpdatedConvertedPart != "`")
            {
                foreach (char symbol in UpdatedConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (UpdatedConvertedPart.Contains("`"))
                    UpdatedConvertedPart = DeleteEpsylons(UpdatedConvertedPart);
            }

            return rules.Update(UpdatedConvertedPart, rule);
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedConvertedPart"> Изменённая строка превращения</param>
        /// <param name="NonTerminalOfRule"> Нетерминал изменяемого правила </param>
        /// <param name="ConvertedPartOfRule"> Строка правила в которую превращается нетерминал</param>
        /// <returns> Правда если изменение успешно, ложь в обратном случае </returns>
        public bool UpdateRule(string UpdatedConvertedPart, char NonTerminalOfRule, string ConvertedPartOfRule)
        {
            if (!non_terminals.Contains(NonTerminalOfRule)) return false;
            if(ConvertedPartOfRule != "`")
            {
                foreach (char symbol in ConvertedPartOfRule)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (ConvertedPartOfRule.Contains("`"))
                    ConvertedPartOfRule = DeleteEpsylons(ConvertedPartOfRule);
            }

            if(UpdatedConvertedPart != "`")
            {
                foreach (char symbol in UpdatedConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (UpdatedConvertedPart.Contains("`"))
                    UpdatedConvertedPart = DeleteEpsylons(UpdatedConvertedPart);
            }

            return rules.Update(UpdatedConvertedPart, new Rule(NonTerminalOfRule, ConvertedPartOfRule));
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedMainNonTerminal"> Изменённый основной нетерминал правила </param>
        /// <param name="UpdatedConvertedPart"> Изменённая строка превращения </param>
        /// <param name="rule"> Изменяемое правило </param>
        /// <returns> Правда если изменение успешно, ложь в обратном случае </returns>
        public bool UpdateRule(char UpdatedMainNonTerminal, string UpdatedConvertedPart, Rule rule)
        {
            if (!non_terminals.Contains(rule.MainNonTerminal)) return false;
            if(rule.ConvertedPart != "`")
            {
                foreach (char symbol in rule.ConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (rule.ConvertedPart.Contains("`"))
                    rule.ConvertedPart = DeleteEpsylons(rule.ConvertedPart);
            }

            if (!non_terminals.Contains(UpdatedMainNonTerminal)) return false;
            if(UpdatedConvertedPart != "`")
            {
                foreach (char symbol in UpdatedConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (UpdatedConvertedPart.Contains("`"))
                    UpdatedConvertedPart = DeleteEpsylons(UpdatedConvertedPart);
            }

            return rules.Update(UpdatedMainNonTerminal,UpdatedConvertedPart, rule);
        }

        /// <summary>
        /// Метод изменения правила
        /// </summary>
        /// <param name="UpdatedMainNonTerminal"> Изменённый основной нетерминал правила </param>
        /// <param name="UpdatedConvertedPart"> Изменённая строка превращения </param>
        /// <param name="NonTerminalOfRule"> Нетерминал изменяемого правила </param>
        /// <param name="ConvertedPartOfRule"> Строка правила в которую превращается нетерминал</param>
        /// <returns> Правда если изменение успешно, ложь в обратном случае </returns>
        public bool UpdateRule(char UpdatedMainNonTerminal, string UpdatedConvertedPart, char NonTerminalOfRule, string ConvertedPartOfRule)
        {
            if (!non_terminals.Contains(NonTerminalOfRule)) return false;
            if(ConvertedPartOfRule != "`")
            {
                foreach (char symbol in ConvertedPartOfRule)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (ConvertedPartOfRule.Contains("`"))
                    ConvertedPartOfRule = DeleteEpsylons(ConvertedPartOfRule);
            }

            if (!non_terminals.Contains(UpdatedMainNonTerminal)) return false;
            if(UpdatedConvertedPart != "`")
            {
                foreach (char symbol in UpdatedConvertedPart)
                    if (!non_terminals.Contains(symbol) && !terminals.Contains(symbol) && symbol != epsylon)
                        return false;
                if (UpdatedConvertedPart.Contains("`"))
                    UpdatedConvertedPart = DeleteEpsylons(UpdatedConvertedPart);
            }

            return rules.Update(UpdatedMainNonTerminal, UpdatedConvertedPart, new Rule(NonTerminalOfRule, ConvertedPartOfRule));
        }

        /// <summary>
        /// Метод удаления правила из набора правил
        /// </summary>
        /// <param name="MainNonTerminal"> Нетерминал из которого исходит правило </param>
        /// <param name="ConvertedPart"> Строка в которую преобразуется нетерминал </param>
        /// <returns> Правда если правило удалено, ложь в обратном случае </returns>
        public bool DeleteRule(char MainNonTerminal, string ConvertedPart)
        {
            if (MainNonTerminal == epsylon) return false;
            ConvertedPart = DeleteEpsylons(ConvertedPart);
            return rules.Delete(new Rule(MainNonTerminal,ConvertedPart));
        }

        /// <summary>
        /// Метод удаления правила из набора правил
        /// </summary>
        /// <param name="rule"> Удаляемое правило </param>
        /// <returns> Правда если правило удалено, ложь в обратном случае </returns>
        public bool DeleteRule(Rule rule)
        {
            if(rule.MainNonTerminal == epsylon) return false;
            rule.ConvertedPart = DeleteEpsylons(rule.ConvertedPart);
            return rules.Delete(rule);
        }

        /// <summary>
        /// Метод позволяющий удалить символ из грамматики
        /// </summary>
        /// <param name="DelSymbol">Удаляемый символ</param>
        /// <returns> Правда если символ удален, ложь в обратном случае </returns>
        public bool DeleteSymbol(char DelSymbol)
        {
            if (DelSymbol == epsylon) return false;
            if (terminals.Contains(DelSymbol)) 
                terminals.Remove(DelSymbol);
            else if (non_terminals.Contains(DelSymbol))
            {
                if (start_symbol == DelSymbol)
                    start_symbol = '\0';
                non_terminals.Remove(DelSymbol);   
            }    
            else                                                                
                return false;
            if (rules.GetRules(DelSymbol).Count > 0)
                return rules.DeleteBySymbol(DelSymbol);
            else
                return true;
        }

        /// <summary>
        /// Метод для построения строки из терминалов входящих в список терминалов
        /// </summary>
        /// <returns> Строка из терминалов </returns>
        public string TerminalsInString()
        {
            if (terminals.Count == 0) return "";
            string result = "{";
            foreach (char symbol in terminals)
                result += symbol + " ";
            result += "}";
            return result;
        }

        /// <summary>
        /// Метод для построения строки из нетерминалов входящих в список нетерминалов
        /// </summary>
        /// <returns></returns>
        public string NonTerminalsInString()
        {
            if (non_terminals.Count == 0) return "";
            string result = "{";
            foreach (char symbol in non_terminals)
                result += symbol + " ";
            result += "}";
            return result;
        }

        /// <summary>
        /// Метод для построения строки из правил входящих в набор правил
        /// </summary>
        /// <returns></returns>
        public string RulesInString()
        {
            if (rules.Count() == 0) return "";
            string result = rules.ToString();
            return result;
        }

        public override string ToString()
        {
            string result = "G = (";
            result += TerminalsInString() + ",";
            result += NonTerminalsInString() + ",";
            result += "P,";
            result += start_symbol + ")\n";
            result += "P: " + RulesInString();
            return result;
        }

        /// <summary>
        /// Метод получения максимального символа по юникоду в грамматике
        /// </summary>
        /// <returns></returns>
        public int GetMaxUNICODESymbol()
        {
            int max_value = 0;
            foreach(char symbol in non_terminals)
                if(Convert.ToInt32(symbol) > max_value)
                    max_value = symbol;
            foreach (char symbol in terminals)
                if (Convert.ToInt32(symbol) > max_value)
                    max_value = symbol;
            return max_value;
        }

        /// <summary>
        /// Метод поиска правил в грамматике которые преобразуют нетерминал в одиночный терминал
        /// </summary>
        /// <returns> Правда если хотя бы одно такое правило найдено, ложь в обратном случае </returns>
        public bool FindRuleWithSingleTerminal()
        {
            foreach (char terminal in Terminals)
                if (rules.FindRule("" + terminal)) return true;
            return false;
        }

        /// <summary>
        /// Метод изменения грамматики для удобного преобразования её в недетерминированный конечный автомат
        /// </summary>
        /// <returns></returns>
        public bool UpdateGrammarForNDA()
        {
            if(rules.Count() == 0) { return false; }
            RemoveUnreachableNonterminals();
            if (FindRuleWithSingleTerminal())
            {
                char temp_symbol = Convert.ToChar(GetMaxUNICODESymbol() + 1);
                AddNonTerminal(temp_symbol);
                rules.UpdateRulesForNDA(temp_symbol);

            }
            return true;
        }

        void RemoveUnreachableNonterminals()
        {
            for (int i = 0; i < NonTerminals.Count; i++)
                if (!ReachableNonterminal(NonTerminals[i]))
                {
                    DeleteSymbol(NonTerminals[i]);
                    i--;
                }
        }

        bool ReachableNonterminal(char non_terminal)
        {
            foreach (var rule in Rules.GetAllRules())
                if (rule.ContainsSymbol(non_terminal))
                    return true;
            return false;
        }
    }
}
