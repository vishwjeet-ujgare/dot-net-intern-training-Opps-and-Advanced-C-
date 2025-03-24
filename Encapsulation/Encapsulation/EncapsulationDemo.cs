using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class EncapsulationDemo
    {
        private double _Amount;
        //private string _CustomerName;
        private readonly string _BankName = "State Bank of India";

        public double Amount
        {
            get { 
                return _Amount;
            }

            set {
                if (value < 0) { 
                    throw new Exception("Please pass Positive Value");
                } else { 
                    _Amount = value;
                }
            }
        
        }


        public string BankName
        {

            get { 
                return _BankName;
            }
        }
        public string CustomerName { get; set; }
           
    }
}
