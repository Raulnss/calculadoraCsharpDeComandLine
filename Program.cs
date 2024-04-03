using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" sinal da operação: ");
           string op = Console.ReadLine();
            Console.WriteLine(" numero: ");
            int n2 = int.Parse(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(n1 + n2); 
            }
            else if (op == "-") {
                Console.WriteLine(n1 - n2);
            }
            else if (op == "*" || op == "x")
            {
                Console.WriteLine(n1 * n2);
            } 
            else if (op == "/")
            {
                Console.WriteLine(n1 / n2);
            }
            else if(op == "%")
            {
                Console.WriteLine(n1 % n2);
            }
            else
            {
                Console.WriteLine(" algo deu errado! ");
            }
            Console.ReadKey();
        }
    }
}
