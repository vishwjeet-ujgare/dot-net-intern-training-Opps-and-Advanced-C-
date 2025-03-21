using System;


namespace Csharp_Oops_Advanced.Delegate_Demo
{
    //Define a delagate
    public delegate void CalDelegate(int a, int b);
    class Understanding_Delagate
    {

        //Handler methods
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition is " + (a + b));
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction is " + (a - b));
        }

        public Understanding_Delagate()
        {
            Console.WriteLine("Hello from delegates");
            //create a instance of delegate
            CalDelegate calDelegate = new CalDelegate(Add);
            //calDelegate.Invoke(6, 6);
            calDelegate(10, 10);


        }
    }
}
