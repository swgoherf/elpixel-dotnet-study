using System;
using System.Collections.Generic;
using System.Text;

namespace homework2.Tasks
{
    public class Task6
    {
        public static bool Run(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
