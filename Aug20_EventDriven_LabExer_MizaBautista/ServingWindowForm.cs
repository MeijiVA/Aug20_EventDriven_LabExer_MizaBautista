using System;
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
    public partial class ServingWindowForm : Form
    {
        public ServingWindowForm()
        {
            InitializeComponent();
            TimerRefresh.Interval = (3 * 1000);
        }

        private void lblServe_Click(object sender, EventArgs e)
        {

        }

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            lblServe.Text = CashierClass.CashierQueue.Peek().ToString();
        }
    }
}
