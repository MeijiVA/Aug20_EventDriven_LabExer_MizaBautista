using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug20_EventDriven_LabExer_MizaBautista.Classes
{
    internal class CashierClass
    {
        //STEP 3 CASHIER CLASS
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }//cashier class 

        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber; 
        }
    }
}
