using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class TransitionTable
    {
        List<char> symbols;
        List<char> states;
        List<SetOfTransitions> transition_table;

        public TransitionTable(Grammar grammar)
        {
            symbols = grammar.Terminals;
            states = grammar.NonTerminals;
            transition_table = CreateTableOfTransitions(grammar);
        }

        public string GetValue(char RowSymbol, char ColumnSymbol)
        {
            if(symbols.IndexOf(ColumnSymbol) == -1) { return ""; }
            if (states.IndexOf(RowSymbol) == -1) { return ""; }
            return transition_table[states.IndexOf(RowSymbol)].GetValueByTerminal(ColumnSymbol);
        }

        public void SetValue(char RowSymbol, char ColumnSymbol, string value)
        {
            if (symbols.IndexOf(RowSymbol) == -1) { return; }
            if (states.IndexOf(ColumnSymbol) == -1) { return; }
            transition_table[states.IndexOf(RowSymbol)].SetValueByTerminal(ColumnSymbol,value);
        }

        public void SetSymbolFinite(char Symbol)
        {
            foreach(SetOfTransitions sot in transition_table)
                if(sot.NonTerminal == Symbol) sot.IsItFinite = true;
        }

        public List<char> GetFiniteStates()
        {
            List<char> finite_states = new List<char>();
            foreach (SetOfTransitions sot in transition_table)
                if (sot.IsItFinite) finite_states.Add(sot.NonTerminal);
            return finite_states;
        }

        List<SetOfTransitions> CreateTableOfTransitions(Grammar grammar)
        {      
            List<SetOfTransitions> tt = new List<SetOfTransitions>();
            foreach(var nonterm in grammar.NonTerminals)
            {
                List<Rule> rules = grammar.Rules.GetRules(nonterm);
                if(rules.Count != 0)
                    tt.Add(new SetOfTransitions(nonterm, grammar.Terminals, rules));
                else
                    tt.Add(new SetOfTransitions(nonterm, grammar.Terminals));
            }
            return tt;
        }
    }
}
