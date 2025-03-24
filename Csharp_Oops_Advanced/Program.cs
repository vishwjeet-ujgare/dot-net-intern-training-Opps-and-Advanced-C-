
using Encapsulation.Encapsulation;
using System;


namespace Csharp_Oops_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Created 4 pillar of OOPS branch");
            //Encapsulation

            try {
                EncapsulationDemo encap = new EncapsulationDemo();
                Console.WriteLine($"Bank Name :  {encap.BankName}");

                encap.CustomerName = "Jeet Ujgare";
                Console.WriteLine($"Customer Name : {encap.CustomerName}");

                encap.Amount = 100.99;
                Console.WriteLine($"Bank Balance : {encap.Amount}");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

    

            
        }
    }
}
