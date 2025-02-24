using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Library
{
    public class DFA
    {
        public HashSet<string> States { get; set; } // Множество состояний
        public HashSet<char> Alphabet { get; set; } // Алфавит
        public Dictionary<(string, char), string> Transitions { get; set; } // Функция переходов
        public string StartState { get; set; } // Начальное состояние
        public HashSet<string> AcceptStates { get; set; } // Множество конечных состояний

        public DFA()
        {
            States = new HashSet<string>();
            Alphabet = new HashSet<char>();
            Transitions = new Dictionary<(string, char), string>();
            AcceptStates = new HashSet<string>();
        }

        // Добавление перехода
        public void AddTransition(string fromState, char input, string toState)
        {
            Transitions[(fromState, input)] = toState;
        }

        public void AddState(String State)
        {
            States.Add(State);
        }

        // Получение перехода
        public string GetTransition(string state, char input)
        {
            return Transitions.TryGetValue((state, input), out var result) ? result : null;
        }
    }
}
