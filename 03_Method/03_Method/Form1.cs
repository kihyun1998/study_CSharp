namespace _03_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tBoxNum1.Text);
            int num2 = int.Parse(tBoxNum2.Text);

            tBoxResult.Text = fSum(num1,num2).ToString();
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tBoxNum1.Text);
            int num2 = int.Parse(tBoxNum2.Text);

            tBoxResult.Text = fSub(num1,num2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tBoxNum1.Text);
            int num2 = int.Parse(tBoxNum2.Text);

            tBoxResult.Text = fDiv(num1,num2).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tBoxNum1.Text);
            int num2 = int.Parse(tBoxNum2.Text);

            int rst = num1 * num2;
            tBoxResult.Text =fMul(num1,num2).ToString();
        }

        private int fSum(int num1, int num2)
        {
            int rst = 0;
            rst = num1 + num2;
            return rst;
        }

        private int fSub(int num1, int num2)
        {
            int rst = 0;
            rst = num1 - num2; 
            return rst;
        }

        private int fDiv(int num1, int num2)
        {
            int rst = 0;
            rst = num1 / num2; 
            return rst;
        }
        
        private int fMul(int num1,int num2)
        {
            int rst = 0;
            rst = num1 * num2;
            return rst;
        }
    }
}