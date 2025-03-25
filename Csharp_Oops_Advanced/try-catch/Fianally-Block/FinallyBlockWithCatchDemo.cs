using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Oops_Advanced.try_catch
{
    class FinallyBlockWithCatchDemo
    {
        public FinallyBlockWithCatchDemo(){
            int Num1, Num2, Result;

            try
            {
                Console.WriteLine("Enter First Number : ");
                Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number : ");
                Num2 = int.Parse(Console.ReadLine());

                Result = Num1 / Num2;
                Console.WriteLine($"Result = {Result}");


            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Second number can not be zero");
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter only integer number ");
            }
            catch (Exception exe)
            {
                Console.WriteLine("Exception Occured : " + exe);
            }
            finally {
                Console.WriteLine("Hello this is finally block...Dont doaut me i will always execute ");
            }
        }
    }
}
