using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Oops_Advanced._20_March_2025._02_Constructores_Destructor.Destructor_Demo
{
    class DestructorDemo
    {
        public DestructorDemo() {
            Console.WriteLine("Constructor is created for destructor Demo");
        }

        ~DestructorDemo() {
            Console.WriteLine("Destructor Demo class is Destroyed");
        }
    }

    class StartDestructorDemo
    {
        public StartDestructorDemo()
        {
            DestructorDemo DD1=new DestructorDemo();
            DestructorDemo DD2=new DestructorDemo();

            DD1 = null;
            GC.Collect();
            Console.ReadKey();


        }
    }
}
