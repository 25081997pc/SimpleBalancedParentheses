using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBalancedParentheses
{
    public class StackParenthesis
    {
        public bool IsParenthesis(String str)
        {
            Stack<char> stack = new Stack<char>();
            for(int i=0;i<str.Length;i++)
            {
                char c = str[i];
                if(c == '[' || c == '(' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ']')
                {
                    if(stack.Count == 0|| stack.Pop() != '[')
                    {
                        return false;
                    }
                }
                else if(c == ')')
                {
                    if(stack.Count == 0|| stack.Pop()!='{')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

    }
}
