namespace Forms
{
    /// <summary>
    /// Класс 'Правило' который позволяет создавать правила для грамматики
    /// </summary>
    public class Rule
    {
        //нетерминал из которого исходит правило
        char main_non_terminal;
        //строка в которую преобразуется нетерминал
        string converted_part;

        /// <summary>
        /// Конструктор простого правила
        /// </summary>
        /// <param name="MainNonTerminal">Нетерминал из которого исходит правило.</param>
        /// <param name="ConvertedPart">Строка в которую преобразуется нетерминал.</param>
        public Rule(char MainNonTerminal, string ConvertedPart)
        {
            main_non_terminal = MainNonTerminal;
            converted_part = ConvertedPart;
        }

        /// <summary>
        /// Нетерминал из которого исходит правило
        /// </summary>
        public char MainNonTerminal { get { return main_non_terminal; } set { main_non_terminal = value; } }
        /// <summary>
        /// Строка в которую преобразуется нетерминал
        /// </summary>
        public string ConvertedPart { get { return converted_part; } set { converted_part = value; } }

        public override string ToString()
        {
            return main_non_terminal + " -> " + ConvertedPart;
        }

        /// <summary>
        /// Метод определяющий равенство правил
        /// </summary>
        /// <param name="rule"> Правило с которым сравниваем данное правило</param>
        /// <returns> Правда если правила равны, ложь если не равны </returns>
        public bool Equals(Rule rule)
        {
            if(rule.MainNonTerminal == main_non_terminal && rule.ConvertedPart == converted_part) return true;
            return base.Equals(false);
        }

        /// <summary>
        /// Метод для поиска символа в правиле
        /// </summary>
        /// <param name="symbol"> Искомый символ </param>
        /// <returns> Правда если символ содержится в правиле, ложь если обратное </returns>
        public bool ContainsSymbol(char symbol)
        {
            if (symbol == main_non_terminal) return true;
            foreach(char sym in converted_part)
                if(sym == symbol) return true;
            return false;
        }
    }
}
