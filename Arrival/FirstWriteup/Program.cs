using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWriteup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Console.WriteLine("World");
            //Console.WriteLine(); // THIS CREATES EMPTY SPACES

            //Console.Write("HELLO");
            //Console.Write("WORLD");

            //Console.WriteLine();

            //string name = "Anita";
            //Console.WriteLine("my name is" + name);


            //int Number1 = 100;
            //int Number2 = 200;
            //int Number3 = 509;


            //int result = Number1 + Number2 + Number3;
            //Console.WriteLine("100 + 200 + 200  + 509 =" + result);

            //result = Number1 * Number2;
            //Console.WriteLine("this results in: " + result);

            //result = Number2 - Number1;
            //Console.WriteLine(result);

            //result = Number3 / Number1;
            //Console.WriteLine(result);

            //result = Number3 % Number2;
            //Console.WriteLine(result);


            ////THIS IS OUR "IF" STATEMENT
            //if (Number2 < Number1)
            //{
            //    Console.WriteLine("Number2 < Number1");
            //}
            //else
            //{
            //    Console.WriteLine(Number2 > Number1);
            //}

          //  Console.WriteLine("Please enter a name");
          //string input =  Console.ReadLine();

          //  if (input.Equals("Munachi") || input.Equals("Mak"))
          //  {
          //    Console.WriteLine("Say Hello");  
          //  }
          //  else
          //  {
          //      Console.WriteLine("Say Goodbye");
          //  }


            //{
            //    Console.WriteLine("PLEASE WRITE A NUMBER");

            //    string number = Console.ReadLine();
            //    int numberConverted = int.Parse(number);

            //    Console.WriteLine(numberConverted = 500);


            //    Console.WriteLine(numberConverted + 500);


            //}


            //int numberToBeControled = 89;

            //while (numberToBeControled < 88) 
            //{
            //    //Console.WriteLine("ON POINT");
            //    numberToBeControled = numberToBeControled + 1;

            //}

            //Console.WriteLine("ALWAYS BE ON POINT");

            //Console.WriteLine("PLEASE DEMAND CLIENT IDENTITY:");
            //string ClientIdentity = Console.ReadLine();

            //do
            //{
             
            //} while (ClientIdentity.Equals("AliBaby"));

            //Console.WriteLine("GIVE AUTHOMATIC PASS IF CLIENT IS CHIBABY");



            //for (int Numricals = 0; Numricals < 8; Numricals += 2)            {
            //    Console.WriteLine("My number is" + Numricals);
            //}

            Console.WriteLine("Please enter grades");

            float grades = float.Parse(Console.ReadLine());

            if ((grades >= 0.00) && (grades <= 0.99))
            {
              Console.WriteLine("Failed Course");  
            }
           else if ((grades >= 1.00) && (grades <= 1.99))
           {
              Console.WriteLine("PASSED"); 
           }


        Console.ReadKey();



        }
    }
}
