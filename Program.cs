using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemana1Final
{
    class Program
    {
        static void ToSelect()
        {
            Console.WriteLine("Welcome to our basic stupidlator, we can only add or substract!");
            Console.WriteLine("Please, select the operation");
            Console.WriteLine("1-Add");
            Console.WriteLine("2-Subtract");

            int operation = int.Parse(Console.ReadLine());

            if(operation == 1 || operation == 2) 
            { 
                Console.WriteLine("How Many Numbers?");
                int Inumbers = int.Parse(Console.ReadLine());

                int[] numbers = new int[Inumbers];

                for (int i = 0; i< Inumbers; i++) 
                {
                    Console.Write($"Insert the number {i + 1}:");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                int result = 0;

                if (operation == 1) 
                {
                    result = Add(numbers);
                }
                else if (operation == 2) 
                {
                    result = Substract(numbers);   
                }
                Console.WriteLine($"The result is: {result} + :D");
            }
            else
            {
                Console.WriteLine("Not possible to execute");
            }
        }
        static int Add(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        static int Substract(int[] numbers)
        {
            int difference = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                difference -= numbers[i];
            }
            return difference;
        }
        static void Main(string[] args)
        {
            ToSelect();
            Console.WriteLine("Press a Key to exit the calculator...");
            Console.ReadKey();
        }

    }
}



