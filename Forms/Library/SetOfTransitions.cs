using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class SetOfTransitions
    {
        char main_symbol;
        bool finish_symbol = true;
        Dictionary<char, string> transitions = new Dictionary<char, string>();

        public char NonTerminal { get { return main_symbol; } }
        public bool IsItFinite { get { return finish_symbol; } set { finish_symbol = value; } }

        public string GetValueByTerminal(char Terminal)
        {
            return transitions[Terminal];
        }

        public void SetValueByTerminal(char Terminal, string Value)
        {
            transitions[Terminal] = Value;
        }

        public SetOfTransitions(char MainNonTerminal, List<char> Terminals, List<Rule> rules)
        {
            main_symbol = MainNonTerminal;
            foreach (char term in Terminals)
                foreach (Rule rule in rules)
                    if (rule.ContainsSymbol(term))
                    {
                        if (transitions.ContainsKey(term))
                            if (transitions[term] == "-")
                                transitions[term] = rule.ConvertedPart[1] + "";
                            else
                                transitions[term] = transitions[term].TrimEnd(' ') + "," + rule.ConvertedPart[1];
                        else
                            transitions.Add(term, rule.ConvertedPart[1] + "");
                    }
                    else
                    {
                        if (!transitions.ContainsKey(term))
                            transitions.Add(term, "-");
                    }
            foreach(string trans in transitions.Values)
                if(trans != "-") { finish_symbol = false; }
        }

        public SetOfTransitions(char MainNonTerminal, List<char> Terminals)
        {
            main_symbol = MainNonTerminal;
            foreach (char term in Terminals)
                transitions.Add(term, "-");
        }
    }
}
