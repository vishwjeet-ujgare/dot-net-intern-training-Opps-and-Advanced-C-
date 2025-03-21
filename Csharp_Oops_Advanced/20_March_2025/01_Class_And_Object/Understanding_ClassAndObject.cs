using System;


namespace Csharp_Oops_Advanced._20_March_2025
{
    class Understanding_ClassAndObject
    {
        public Understanding_ClassAndObject() {
       
                Calculator cal = new Calculator();
               int result= cal.add(10, 20);
            Console.WriteLine("Addition of two numbers is : " + result);
        }
    }


    class Calculator { 
    
        public int add(int a, int b)
        {
            return a + b;
        }
    }
}
