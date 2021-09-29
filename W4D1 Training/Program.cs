using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            


            
            try
            {
                double Principle;
                Console.WriteLine("\nPrinciple Amount : ");
                Principle = double.Parse(Console.ReadLine());

                double Interest;
                Console.WriteLine("\nInterest Amount : ");
                Interest = double.Parse(Console.ReadLine());

                double Months;
                Console.WriteLine("\nNo of Months : ");
                Months = double.Parse(Console.ReadLine());

                simpleinterest_calc calc = new simpleinterest_calc();

                calc.CalculateSimpleInterest += Calc_CalculateSimpleInterest; // Subscription to event

                calc.Calculate(Principle, Interest, Months);
                Console.ReadLine();
            }

            catch (FormatException)
            {
                Console.WriteLine("Wrong Input");
            }
            

            
        }

        private static void Calc_CalculateSimpleInterest(object sender, interestEventArgs e)
        {
            Console.WriteLine(e.simpleinterest);
        }

















































        //static void Main(string[] args)
        //{



        //    try
        //    {
        //        int a;
        //        Console.Write("\nFirst Input : ");
        //        a = Int32.Parse(Console.ReadLine());

        //        int b;
        //        Console.Write("\nSecond Input : ");
        //        b = Int32.Parse(Console.ReadLine());

        //        Divide_param div = new Divide_param();

        //        Console.WriteLine("\nDivide : {0} ", div.Divide(a, b));
        //    }

        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine($"Cannot divide by zero");
        //    }

        //    catch (FormatException)
        //    {
        //        Console.WriteLine($"Wrong input");
        //    }

        //    finally
        //    {
        //        Console.WriteLine("Finally block");
        //    }

        //    Console.ReadLine();







        //}
    }
}
