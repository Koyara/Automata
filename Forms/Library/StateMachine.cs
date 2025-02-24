using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    /// <summary>
    /// Класс недетерминированного конечного автомата
    /// </summary>
    public class StateMachine
    {
        // Таблица переходов
        TransitionTable transition_table;
        //Список состояний автомата
        List<char> states;
        //Список конечных состояний автомата
        List<char> finish_states;
        //Начальное состояние автомата
        char start_state;
        //Конечный алфавит
        List<char> terminals;

        public List<char> FiniteStates { get { return finish_states; }}
        public List<char> States { get { return states; } }
        public List<char> Alphabet { get { return terminals; } }
        public char StartState { get { return start_state; } }

        public StateMachine(Grammar regular_grammar)
        {
            Grammar temp = regular_grammar;
            temp.UpdateGrammarForNDA();
            terminals = temp.Terminals;
            states = temp.NonTerminals;
            start_state = temp.StartSymbol;
            transition_table = new TransitionTable(temp);
            finish_states = transition_table.GetFiniteStates();
            if(temp.Rules.HaveEpsylonRules(start_state))
            {
                finish_states.Add(start_state);
                transition_table.SetSymbolFinite(start_state);
            }
        }

        public override string ToString()
        {
            string result = "M=(";
            result += StatesInString() + ", ";
            result += AlphabethInString() + ", ";
            result += start_state + ", T, ";
            result += FiniteStatesInString() + ")\nT:\n";
            result += TransitionTableInString();
            return result;
        }

        string FiniteStatesInString()
        {
            string result = "{";
            foreach (var finite_state in finish_states)
                result += finite_state + " ";
            result += "}";
            return result;
        }

        string AlphabethInString()
        {
            string result = "{";
            foreach (var terminal in terminals)
                result += terminal + " ";
            result += "}";
            return result;
        }

        string StatesInString()
        {
            string result = "{";
            foreach (var state in states)
                result += state + " ";
            result += "}";
            return result;
        }

        string TransitionTableInString()
        {
            string result = "   ";
            foreach (char term in terminals)
                result += $"{term,6}";
            result += "\n";
            foreach (char nonterm in states)
            {
                if (nonterm == start_state)
                {
                    if (finish_states.Contains(start_state)) result += $"{nonterm + "`*",3}";
                    else result += $"{nonterm + "`",3}";
                }
                else if (finish_states.Contains(nonterm)) result += $"{nonterm + "*",3}";
                else result += $"{nonterm,3}";
                foreach (char term in terminals)
                    result += $"{transition_table.GetValue(nonterm, term),6}";
                result += "\n";
            }
            return result;
        }
    }
}
