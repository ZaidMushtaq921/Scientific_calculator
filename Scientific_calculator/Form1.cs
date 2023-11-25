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

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtresult.Text);
            op = num.Text;
            txtresult.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtresult.Text);
            switch (op)
            {
                case "+":

                    txtresult.Text = (enterFirstValue + enterSecondValue).ToString();


                    break;

                case "-":
                    txtresult.Text = (enterFirstValue - enterSecondValue).ToString();


                    break;

                case "*":

                    txtresult.Text = (enterFirstValue * enterSecondValue).ToString();

                    break;

                case "/":

                    txtresult.Text = (enterFirstValue / enterSecondValue).ToString();


                    break;
                default:



                    break;
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
            String f,s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);
            f = " ";
            s = " ";
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtresult.Text);
            txtresult.Text = Convert.ToString(-1 * q);

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if(txtresult.Text.Length >0)
            {
                txtresult.Text = txtresult.Text.Remove(txtresult.Text.Length - 1, 1);
            }
            if (txtresult.Text=="")
            {
                txtresult.Text = "0";
            }
        }
    }
}
