using Csharp_Oops_Advanced.Custome_Exception_Demo.Cutomer_Exception_Classed;
using System;


namespace Csharp_Oops_Advanced.Custome_Exception_Demo.Call_Custome_Exception
{
    class ThrowOddNumberExceptionDemo
    {

        public ThrowOddNumberExceptionDemo() {

            int Num1, Num2, Result;
            try {
                Console.WriteLine("Enter First number : ");
                Num1=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number : ");
                Num2=int.Parse(Console.ReadLine());

                if (Num2 % 2 > 0) { 
                    throw new OddNumberException();
                }

                Result = Num1 / Num2;
                Console.WriteLine("Output is : "+Result);
            } 
            catch (OddNumberException one)
            {
                Console.WriteLine($"Message: {one.Message}");
                Console.WriteLine($"HelpLink: {one.HelpLink}");
                Console.WriteLine($"Source: {one.Source}");
                Console.WriteLine($"StackTrace: {one.StackTrace}");
            }

            Console.WriteLine("End of the Program");
            Console.ReadKey();
        }
    }
}
