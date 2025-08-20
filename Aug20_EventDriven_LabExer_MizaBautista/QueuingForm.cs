using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aug20_EventDriven_LabExer_MizaBautista.Classes;

namespace Aug20_EventDriven_LabExer_MizaBautista
{
    public partial class QueuingForm : Form
    {
        public QueuingForm()
        {
            InitializeComponent();
            //STEP 6
            cashier = new CashierClass();
        }

        //STEP 5
        private CashierClass cashier;

        //STEP 4
        private void btnCashier_Click(object sender, EventArgs e)
        {
            //STEP 7
            lblQueue.Text = cashier.CashierGeneratedNumber("p - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
