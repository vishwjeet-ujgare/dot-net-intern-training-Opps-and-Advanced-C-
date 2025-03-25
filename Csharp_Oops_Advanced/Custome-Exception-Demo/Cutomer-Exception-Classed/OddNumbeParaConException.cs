using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Oops_Advanced.Custome_Exception_Demo.Cutomer_Exception_Classed
{
    class OddNumbeParaConException:Exception
    {
        public OddNumbeParaConException() { }

        public OddNumbeParaConException(string message) : base(message) { }

        public OddNumbeParaConException(string message, Exception inner)
          : base(message, inner)
        {
        }

        //Overriding the HelpLink Property
        public override string HelpLink
        {
            get
            {
                return "Get More Information from here: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
            }
        }
    }
}
