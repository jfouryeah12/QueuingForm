namespace QueuingSystem
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Modify
        private CashierClass cashier = new CashierClass();
        public Form()
        {
            InitializeComponent();
           
        }
        //Start
        private void btnCashier_Click(object sender, EventArgs e)
        {
            
            
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}