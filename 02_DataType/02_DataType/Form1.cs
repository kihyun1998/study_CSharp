namespace _02_DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            short sNum = 0;
            int iNum = 0;
            double dNum = 0;
            lblException.Text = "-";

            if (short.TryParse(tboxNumber.Text, out sNum))
            {
                lblShort.Text = sNum.ToString();
                lblint.Text = "0";
                lblDouble.Text = "0";
            }
            else if(int.TryParse(tboxNumber.Text,out iNum))
            {
                lblint.Text = iNum.ToString();
                lblShort.Text = "0";
                lblDouble.Text = "0";
            }
            else if(double.TryParse(tboxNumber.Text, out dNum))
            {
                lblDouble.Text = dNum.ToString();
                lblint.Text = "0";
                lblShort.Text = "0";
            }
            else
            {
                lblException.Text = "Can't convert";
            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short sNum = short.Parse(tboxNumber.Text);
                lblShort.Text = sNum.ToString();
                lblException.Text = "-";
                lblint.Text = "0";
                lblDouble.Text = "0";   
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }

        }

        private void btnint_Click(object sender, EventArgs e)
        {
            try
            {
                int iNum = int.Parse(tboxNumber.Text);
                lblint.Text = iNum.ToString();
                lblException.Text = "-";
                lblShort.Text = "0";    
                lblDouble.Text = "0";   
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double dNum = double.Parse(tboxNumber.Text);
                lblDouble.Text = dNum.ToString();
                lblException.Text = "-";
                lblint.Text="0";
                lblShort.Text="0";  
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }
    }
}