using System;


namespace Abstraction
{
   public class AbstractionDemo
    {
        public AbstractionDemo() { 
        
            RBIRulesForATM sbiAtm=new SBIAtm();
            sbiAtm.ValidateUserCard();
            sbiAtm.CheckBalanace();
            sbiAtm.DepositsMoney();
            sbiAtm.WithdrawMoney();



        }

    }

    abstract class RBIRulesForATM {
        public abstract void ValidateUserCard();//enter user pass ,numberetc
        public abstract void CheckBalanace();
        public abstract void DepositsMoney();
        public abstract void WithdrawMoney();
        public abstract void ChangeMobileNumber();
        public abstract void MiniStatement();
    }


    class SBIAtm : RBIRulesForATM {
        public override void ValidateUserCard() {
            Console.WriteLine("Card Validation is does using card and password");
        }

        public override void CheckBalanace()
        {
            Console.WriteLine("SBI Bank !  Your accoun balance is displayed on screen");
        }

        public override void DepositsMoney()
        {

            Console.WriteLine("SBI Bank !  Your money is deposited");
        }

        public override void ChangeMobileNumber()
        {
            Console.WriteLine("SBI Bank !  Your mobile number is changed");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank !  Money is with Drawed");
        }                                       
                                                
        public override void MiniStatement()    
        {
            Console.WriteLine("SBI Bank ! Here is your Mini Statement");

        }


    }

    class HDFCAtm : RBIRulesForATM
    {
        public override void ValidateUserCard()
        {
            Console.WriteLine("HDFC Bank! Card Validation is does using card and password");
        }

        public override void CheckBalanace()
        {
            Console.WriteLine("HDFC Bank! Your account balance is displayed on screen");
        }

        public override void DepositsMoney()
        {

            Console.WriteLine("HDFC Bank! Your money is deposited");
        }

        public override void ChangeMobileNumber()
        {
            Console.WriteLine("HDFC Bank! Your mobile number is changed");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("HDFC Bank! Money is with Drawed");
        }

        public override void MiniStatement()
        {
            Console.WriteLine("HDFC Bank!! Here is your Mini Statement");

        }


    }

}
