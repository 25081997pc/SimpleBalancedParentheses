using SimpleBalancedParentheses;

namespace SimpleBalancedParenthesis
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Expression : ");
            string expression = Console.ReadLine();
            StackParenthesis stackParenthesis = new StackParenthesis();

            if(stackParenthesis.IsParenthesis(expression))
            {
                Console.WriteLine("Balanced Parenthesis");
            }
            else
            {
                Console.WriteLine("Not Balanced Parenthesis");
            }

            
        }
    }
}