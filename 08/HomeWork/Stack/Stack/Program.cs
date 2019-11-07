using System;
using System.Collections.Generic;
namespace Stack
{
    class Program
    {
        static bool Validation(string chars)
        {
            var stack = new Stack<char>();
            foreach (var t in chars)
            {
                switch (t)
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(t);
                        break;

                    case ']':
                        if (stack.Count == 0) return false;
                        if (stack.Peek() != '[') return false;
                        stack.Pop();
                        break;
                    case ')':
                        if (stack.Count == 0) return false;
                        if (stack.Peek() != '(') return false;
                        stack.Pop();
                        break;
                    case '}':
                        if (stack.Count == 0) return false;
                        if (stack.Peek() != '{') return false;
                        stack.Pop();
                        break;
                }
            }
            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку со скобками:");
            string chars = Console.ReadLine();

            Console.WriteLine(Validation(chars));
            Console.ReadKey();
        }
    }
}
