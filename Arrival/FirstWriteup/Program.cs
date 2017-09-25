using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWriteup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("World");
             Console.WriteLine(); // THIS CREATES EMPTY SPACES
            
            Console.Write("HELLO");
            Console.Write("WORLD");

        Console.WriteLine();

            string name = "Anita";
            Console.WriteLine("my name is" + name);


            int Number1= 100;
            int Number2= 200;
            int Number3 = 509;


            int result = Number1 + Number2 + Number3;
            Console.WriteLine("100 + 200 + 200  + 509 =" +result);

            result = Number1*Number2;
            Console.WriteLine( "this results in: " + result);

            result = Number2 - Number1;
            Console.WriteLine(result);

            result = Number3/Number1;
            Console.WriteLine(result);

            result = Number3%Number2;
            Console.WriteLine(result);

            
            //THIS IS OUR "IF" STATEMENT
            if (Number2 < Number1)
            {
                Console.WriteLine("Number2 < Number1");
            }
            else
            {
                Console.WriteLine(Number2 > Number1);
            }
            Console.ReadKey();

          

        }
    }
}
