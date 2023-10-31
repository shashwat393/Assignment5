using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay1
{
    public class Account
    {
       
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        String accountType;
        public String AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            }
        }
        double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public bool WithDraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
        public String GetDetails()
        {
            StringBuilder s = new StringBuilder();

            s.Append($"Id is :{id} \n");
            s.Append($"Balance is :{balance} \n");
            s.Append($"AccountType is :{accountType} \n");
            return Convert.ToString(s);

        }
        public Account()
        {
            id = 0;
            balance = 0;
            accountType = "";
        }
    }
}
