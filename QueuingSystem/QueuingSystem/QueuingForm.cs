namespace QueuingSystem
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Goddamn Class
        private CashierClass cashier = new CashierClass();
        //Goddman Declared
  
        public Form()
        {
            InitializeComponent();
        }

        //BUTTON CASHIER
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }

    }
}