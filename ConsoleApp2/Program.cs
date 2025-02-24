using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ConsoleApp2
{
    // Класс для представления ДКА
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

        // Получение перехода
        public string GetTransition(string state, char input)
        {
            return Transitions.TryGetValue((state, input), out var result) ? result : null;
        }
    }

    class Program
    {
        static DFA dfa1 = new DFA();
        static DFA dfa2 = new DFA();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВыберите ДКА для работы:");
                Console.WriteLine("1. ДКА 1");
                Console.WriteLine("2. ДКА 2");
                Console.WriteLine("3. Построить пересечение ДКА 1 и ДКА 2");
                Console.WriteLine("4. Выход");
                Console.Write("Ваш выбор: ");

                string dfaChoice = Console.ReadLine();

                if (dfaChoice == "4")
                {
                    break;
                }

                if (dfaChoice == "3")
                {
                    // Построить пересечение ДКА 1 и ДКА 2
                    DFA intersectionDFA = IntersectDFA(dfa1, dfa2);
                    intersectionDFA = RemoveUnreachableStates(intersectionDFA);

                    ShowDFA(dfa1);
                    ShowDFA(dfa2);


                    Console.WriteLine("\nРезультат пересечения ДКА 1 и ДКА 2:");
                    ShowDFA(intersectionDFA);
                    continue;
                }

                DFA selectedDFA = dfaChoice == "1" ? dfa1 : dfa2;

                if (selectedDFA != null)
                {
                    ManageDFA(selectedDFA);
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                }
            }
        }

        static void ManageDFA(DFA dfa)
        {
            while (true)
            {
                Console.WriteLine("\nМеню управления ДКА:");
                Console.WriteLine("1. Добавить состояние");
                Console.WriteLine("2. Удалить состояние");
                Console.WriteLine("3. Добавить символ алфавита");
                Console.WriteLine("4. Удалить символ алфавита");
                Console.WriteLine("5. Добавить переход");
                Console.WriteLine("6. Удалить переход");
                Console.WriteLine("7. Установить начальное состояние");
                Console.WriteLine("8. Добавить конечное состояние");
                Console.WriteLine("9. Удалить конечное состояние");
                Console.WriteLine("10. Показать текущий ДКА");
                Console.WriteLine("11. Вернуться к выбору ДКА");
                Console.Write("Выберите опцию: ");

                string choice = Console.ReadLine();

                if (choice == "11")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        AddState(dfa);
                        break;
                    case "2":
                        RemoveState(dfa);
                        break;
                    case "3":
                        AddSymbol(dfa);
                        break;
                    case "4":
                        RemoveSymbol(dfa);
                        break;
                    case "5":
                        AddTransition(dfa);
                        break;
                    case "6":
                        RemoveTransition(dfa);
                        break;
                    case "7":
                        SetStartState(dfa);
                        break;
                    case "8":
                        AddAcceptState(dfa);
                        break;
                    case "9":
                        RemoveAcceptState(dfa);
                        break;
                    case "10":
                        ShowDFA(dfa);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static void AddState(DFA dfa)
        {
            Console.Write("Введите состояние: ");
            string state = Console.ReadLine();
            dfa.States.Add(state);
            Console.WriteLine($"Состояние '{state}' добавлено.");
        }

        static void RemoveState(DFA dfa)
        {
            Console.WriteLine("\nСуществующие состояния:");
            foreach (var s in dfa.States)
            {
                Console.WriteLine(s);
            }

            Console.Write("Введите состояние для удаления: ");
            string state = Console.ReadLine();
            if (dfa.States.Remove(state))
            {
                Console.WriteLine($"Состояние '{state}' удалено.");
                // Удалить все переходы, связанные с этим состоянием
                var transitionsToRemove = dfa.Transitions.Keys
                    .Where(key => key.Item1 == state || dfa.Transitions[key] == state)
                    .ToList();
                foreach (var key in transitionsToRemove)
                {
                    dfa.Transitions.Remove(key);
                }
            }
            else
            {
                Console.WriteLine($"Состояние '{state}' не найдено.");
            }
        }

        static void AddSymbol(DFA dfa)
        {
            Console.Write("Введите символ алфавита: ");
            char symbol = Console.ReadLine()[0];
            dfa.Alphabet.Add(symbol);
            Console.WriteLine($"Символ '{symbol}' добавлен в алфавит.");
        }

        static void RemoveSymbol(DFA dfa)
        {
            Console.WriteLine("\nСуществующие символы алфавита:");
            foreach (var s in dfa.Alphabet)
            {
                Console.WriteLine(s);
            }

            Console.Write("Введите символ алфавита для удаления: ");
            char symbol = Console.ReadLine()[0];
            if (dfa.Alphabet.Remove(symbol))
            {
                Console.WriteLine($"Символ '{symbol}' удален из алфавита.");
                // Удалить все переходы, связанные с этим символом
                var transitionsToRemove = dfa.Transitions.Keys
                    .Where(key => key.Item2 == symbol)
                    .ToList();
                foreach (var key in transitionsToRemove)
                {
                    dfa.Transitions.Remove(key);
                }
            }
            else
            {
                Console.WriteLine($"Символ '{symbol}' не найден в алфавите.");
            }
        }

        static void AddTransition(DFA dfa)
        {
            Console.Write("Введите исходное состояние: ");
            string fromState = Console.ReadLine();
            Console.Write("Введите символ алфавита: ");
            char input = Console.ReadLine()[0];
            Console.Write("Введите целевое состояние: ");
            string toState = Console.ReadLine();

            if (dfa.States.Contains(fromState) && dfa.States.Contains(toState) && dfa.Alphabet.Contains(input))
            {
                dfa.AddTransition(fromState, input, toState);
                Console.WriteLine($"Переход '{fromState} --{input}--> {toState}' добавлен.");
            }
            else
            {
                Console.WriteLine("Ошибка: состояние или символ алфавита не существуют.");
            }
        }

        static void RemoveTransition(DFA dfa)
        {
            Console.WriteLine("\nСуществующие переходы:");
            foreach (var transition in dfa.Transitions)
            {
                Console.WriteLine($"{transition.Key.Item1} --{transition.Key.Item2}--> {transition.Value}");
            }

            Console.Write("Введите исходное состояние: ");
            string fromState = Console.ReadLine();
            Console.Write("Введите символ алфавита: ");
            char input = Console.ReadLine()[0];

            if (dfa.Transitions.Remove((fromState, input)))
            {
                Console.WriteLine($"Переход '{fromState} --{input}--> ...' удален.");
            }
            else
            {
                Console.WriteLine("Переход не найден.");
            }
        }

        static void SetStartState(DFA dfa)
        {
            Console.Write("Введите начальное состояние: ");
            string state = Console.ReadLine();
            if (dfa.States.Contains(state))
            {
                dfa.StartState = state;
                Console.WriteLine($"Начальное состояние установлено на '{state}'.");
            }
            else
            {
                Console.WriteLine($"Состояние '{state}' не найдено.");
            }
        }

        static void AddAcceptState(DFA dfa)
        {
            Console.Write("Введите конечное состояние: ");
            string state = Console.ReadLine();
            if (dfa.States.Contains(state))
            {
                dfa.AcceptStates.Add(state);
                Console.WriteLine($"Конечное состояние '{state}' добавлено.");
            }
            else
            {
                Console.WriteLine($"Состояние '{state}' не найдено.");
            }
        }

        static void RemoveAcceptState(DFA dfa)
        {
            Console.WriteLine("\nСуществующие конечные состояния:");
            foreach (var s in dfa.AcceptStates)
            {
                Console.WriteLine(s);
            }

            Console.Write("Введите конечное состояние для удаления: ");
            string state = Console.ReadLine();
            if (dfa.AcceptStates.Remove(state))
            {
                Console.WriteLine($"Конечное состояние '{state}' удалено.");
            }
            else
            {
                Console.WriteLine($"Конечное состояние '{state}' не найдено.");
            }
        }

        static void ShowDFA(DFA dfa)
        {
            Console.WriteLine("\nТекущий ДКА:");
            Console.WriteLine("Состояния: " + string.Join(", ", dfa.States));
            Console.WriteLine("Алфавит: " + string.Join(", ", dfa.Alphabet));
            Console.WriteLine("Начальное состояние: " + dfa.StartState);
            Console.WriteLine("Конечные состояния: " + string.Join(", ", dfa.AcceptStates));
            Console.WriteLine("Переходы:");
            foreach (var transition in dfa.Transitions)
            {
                Console.WriteLine($"{transition.Key.Item1} --{transition.Key.Item2}--> {transition.Value}");
            }
        }

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
}