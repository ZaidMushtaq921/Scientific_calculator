namespace Scientific_calculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtresult.Text == "0")
                txtresult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtresult.Text.Contains("."))
                    {
                        txtresult.Text = txtresult.Text + num.Text;
                    }
                }
                else
                {
                    txtresult.Text = txtresult.Text + num.Text;
                }
            }
        }
    }
}
