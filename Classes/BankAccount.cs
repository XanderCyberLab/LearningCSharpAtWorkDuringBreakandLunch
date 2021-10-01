using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningCSharpAtWorkDuringBreakandLunch
{
    public class BankAccount
    {
        private float balance;
        public float Balance //Properties
        {
            get //Be able to call the balance 
            {
                return balance;
            }
            private set //Private set can't change it
            {
                if (value >= 0) //If statements prevents the account balance to go negative
                    balance = value;
                else
                    balance = 0;
            }
        }

        private string owner;


        public BankAccount(float balance, string owner) //ctor x2 tab Constructor
        {
            Balance = balance;
            this.owner = owner;
        }


        public virtual float AddBalance(float balanceToBeAdded)
        {
            return Balance = balance + balanceToBeAdded;
        }
        public virtual float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative) //Overloading Methods

        {
            if (balanceCanBeNegative)
                balance = balance + balanceToBeAdded;
            else
                Balance = balance + balanceToBeAdded;
            return Balance;
        }
        public float WithdrawnBalance(float balanceToBeRemoved)
        {
            return Balance = balance - balanceToBeRemoved;
        }
        
    }

    public class ChildBankAccount : BankAccount
    {
        public string Parent { get; set; }

        public ChildBankAccount(float balance, string owner, string parent) : base(balance, owner) //Creating a Constructor for Child class 
                                                                                    //and passing some parameters as BankAccount
        {
            Parent = parent;
        }
        public override float AddBalance(float balanceToBeAdded)
        {
            if(balanceToBeAdded >= -10)
            return base.AddBalance(balanceToBeAdded);
            return Balance;
        }
        public override float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
        {
            if(balanceToBeAdded >= -10)
            return base.AddBalance(balanceToBeAdded, balanceCanBeNegative);
            return Balance;

        }
    }
}
