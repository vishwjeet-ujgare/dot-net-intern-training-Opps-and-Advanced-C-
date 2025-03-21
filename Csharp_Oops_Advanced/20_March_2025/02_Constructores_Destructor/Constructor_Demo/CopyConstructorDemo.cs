using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_Oops_Advanced._20_March_2025._02_Constructores
{
    class CopyConstructorDemo
    {
        int age,familyMemCount,childrenCount,year,mobileNumberCount;
        public CopyConstructorDemo(int a, int f, int c, int y , int m) {
            age = a;
            familyMemCount = f; 
            childrenCount = c;
            year = y;
            mobileNumberCount = m;
        }

        public CopyConstructorDemo(CopyConstructorDemo CCObj) {
            age= CCObj.age;
            familyMemCount= CCObj.familyMemCount;
            childrenCount= CCObj.childrenCount;
            year= CCObj.year;
            mobileNumberCount= CCObj.mobileNumberCount;
        }

        public void Display() {
            Console.WriteLine($"Detail of family memebers :");
            Console.WriteLine($"    Age : {age}");
            Console.WriteLine($"    Family Mem Count : {familyMemCount}");
            Console.WriteLine($"    Children  Count : {childrenCount}");
            Console.WriteLine($"    Year  : {year}");
            Console.WriteLine($"    Mobile Number Count  : {mobileNumberCount}");
        }
    }


    class RunCopyConstructor{

        public RunCopyConstructor() {
            CopyConstructorDemo copyConctructor = new CopyConstructorDemo(25,4,0,2025,1);
            copyConctructor.Display();

            Console.WriteLine("=====================================");
            CopyConstructorDemo CC1=new CopyConstructorDemo(copyConctructor);
            CC1.Display();
        }
    }
}
