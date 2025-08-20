using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aug20_EventDriven_LabExer_MizaBautista.Classes;

namespace Aug20_EventDriven_LabExer_MizaBautista
{
    public partial class CashierWindowQueue : Form
    {
        public CashierWindowQueue()
        {
            //STEP 13
            InitializeComponent();
            timerRefresh.Interval = (3 * 1000);//3seconds
            timerRefresh.Enabled = true;
        }

        //STEP 9
       private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        //STEP 10
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //STEP 12
            CashierClass.CashierQueue.Dequeue();
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
