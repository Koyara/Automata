using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Kurs.Library
{
    class Operations
    {
        // Построение пересечения двух ДКА
        static DFA IntersectDFA(DFA dfa1, DFA dfa2)
        {
            DFA result = new DFA();

            // Алфавит должен быть одинаковым
            result.Alphabet = new HashSet<char>(dfa1.Alphabet.Intersect(dfa2.Alphabet));

            // Начальное состояние
            string startState = $"({dfa1.StartState},{dfa2.StartState})";
            result.StartState = startState;
            result.States.Add(startState);

            // Очередь для обхода состояний
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(startState);

            // Построение переходов
            while (queue.Count > 0)
            {
                string currentState = queue.Dequeue();
                string[] parts = currentState.Trim('(', ')').Split(',');
                string state1 = parts[0];
                string state2 = parts[1];

                // Проверка, является ли состояние конечным
                if (dfa1.AcceptStates.Contains(state1) && dfa2.AcceptStates.Contains(state2))
                {
                    result.AcceptStates.Add(currentState);
                }

                // Построение переходов для каждого символа алфавита
                foreach (char symbol in result.Alphabet)
                {
                    string nextState1 = dfa1.GetTransition(state1, symbol);
                    string nextState2 = dfa2.GetTransition(state2, symbol);

                    if (nextState1 != null && nextState2 != null)
                    {
                        string nextState = $"({nextState1},{nextState2})";
                        result.AddTransition(currentState, symbol, nextState);

                        if (!result.States.Contains(nextState))
                        {
                            result.States.Add(nextState);
                            queue.Enqueue(nextState);
                        }
                    }
                }
            }

            return result;
        }

        // Удаление недостижимых состояний
        static DFA RemoveUnreachableStates(DFA dfa)
        {
            HashSet<string> reachableStates = new HashSet<string>();
            Queue<string> queue = new Queue<string>();

            // Начинаем с начального состояния
            reachableStates.Add(dfa.StartState);
            queue.Enqueue(dfa.StartState);

            // Обход в ширину для поиска достижимых состояний
            while (queue.Count > 0)
            {
                string currentState = queue.Dequeue();

                foreach (char symbol in dfa.Alphabet)
                {
                    string nextState = dfa.GetTransition(currentState, symbol);
                    if (nextState != null && !reachableStates.Contains(nextState))
                    {
                        reachableStates.Add(nextState);
                        queue.Enqueue(nextState);
                    }
                }
            }

            // Удаление недостижимых состояний
            dfa.States.IntersectWith(reachableStates);
            dfa.AcceptStates.IntersectWith(reachableStates);

            // Удаление недостижимых переходов
            var transitionsToRemove = dfa.Transitions.Keys
                .Where(key => !reachableStates.Contains(key.Item1))
                .ToList();

            foreach (var key in transitionsToRemove)
            {
                dfa.Transitions.Remove(key);
            }

            return dfa;
        }
    }
