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
using Timer = System.Windows.Forms.Timer;

namespace QueuingSystem
{
    public partial class CashierWindowQueue : System.Windows.Forms.Form
    {
        public CashierWindowQueue()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 1 sec
            timer.Tick += new EventHandler(timer1_tick); //timer1_tick represents the name of Tick Event
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void timer1_tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void DisplayCashierQueue(IEnumerable CashierList) 
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList) 
            {
               listCashierQueue.View = View.List; //Addition to change the Vertical
                listCashierQueue.Items.Add(obj.ToString());
                
            }
        }
    }
}
