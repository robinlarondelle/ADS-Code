using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Class5.ListeningClass
{
    class InBalance
    {
        public void Run()
        {
            string s = "{[(<>)]}";
            Console.WriteLine("These parantheses: {0} are complete -> {1}", s, CheckBalance(s));
        }

        private bool CheckBalance(string input)
        {
            IMyStack<char> stack = new MyStack.StackImplementation<char>();

            foreach (char c in input)
            {
                if (c.Equals('{') || c.Equals('[') || c.Equals('<') || c.Equals('('))
                {
                    stack.Push(c);
                }
                else if (
                    c.Equals('}') && stack.Count != 0 && stack.Peek().Equals('{') ||
                    c.Equals(']') && stack.Count != 0 && stack.Peek().Equals('[') ||
                    c.Equals('>') && stack.Count != 0 && stack.Peek().Equals('<') ||
                    c.Equals(')') && stack.Count != 0 && stack.Peek().Equals('('))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
