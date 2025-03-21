using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Oops_Advanced._20_March_2025._02_Constructores
{
    class ConstructorDemo
    {
        //Default Constructor will assigne values 
        int age;
        double amount;


        //Constructor is a special method which will be called when object is created
        //Constructor will not have any return type
        //Constructor will have same name as class name
        //Constructor will not have any return type
        //Constructor can have parameters
        //Constructor can have multiple parameters
        //Constructor can have multiple constructors
        
        public ConstructorDemo() {

            //intialize paramets with default valeus

            //age = 0;
            //amount = 0;

            //constructor can have return without any values to exist earyl but till 
            //it will create a object
            return;
        
        }

       

        //we can not define a method same as class name 
        //public void ConstructorDemo() { 
        //}

        public void DisplayValues() {
            Console.WriteLine("Age : "+age);
            Console.WriteLine("Amoutn : " + amount);
        }
    }



}
