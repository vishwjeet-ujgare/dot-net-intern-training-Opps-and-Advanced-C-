using System;


namespace Csharp_Oops_Advanced.Custome_Exception_Demo.Cutomer_Exception_Classed
{
    public class OddNumberException:Exception
    {
        //public override string Message => base.Message;
        public override string Message {
            get {
                return "This is custome Erroe :  Divisor Cannot be Odd Number";
            }
        }

        public override string HelpLink
        {
            get
            {
                return "Get More Information from here: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
            }
        }

    }
}
