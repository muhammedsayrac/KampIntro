using System;

namespace Methods28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var results = Add2();


            int number1 = 20;
            int number2 = 100;

            var results2= Add3(number1, number2)

            Console.WriteLine(results2);
            Console.WriteLine(number1);
            Console.ReadLine();
            
        }


        static void Add()
        {
            Console.WriteLine("Added!!!!");
        }


        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;

        }

        static int Add3(int number1, int number2)
        {
            return number1 + number2;
        }


    }
}
