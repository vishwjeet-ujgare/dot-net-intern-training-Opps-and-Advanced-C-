using System;
using Encapsulation;


namespace Csharp_Oops_Advanced
{
    class EncapsulationDemoCaller
    {
        public EncapsulationDemoCaller() {


            try
            {
                EncapsulationDemo encap=new EncapsulationDemo();
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
