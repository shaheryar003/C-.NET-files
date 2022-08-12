using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("HELLO WORLD");

             Console.ReadKey();
            int num = 10;
            if (num%2==0)
            {
                Console.WriteLine("{0} IS EVEN",num);
                    Console.ReadKey();
            }*/
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 10:Console.WriteLine("IT IS 10");break;
                case 20: Console.WriteLine("IT IS 20"); break;
                case 30: Console.WriteLine("IT IS 30"); break;
                default:Console.WriteLine("NOT 10,20 OR 30");
                    break;
            }
            Console.ReadKey();
        }
    }
}
