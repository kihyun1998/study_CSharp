namespace _04_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnls_Click(object sender, EventArgs e)
        {
            int rst = 0;
            int tmp = int.Parse(tboxRst.Text);
            int num = int.Parse(tboxNum.Text);

            rst = tmp << num;
            tboxRst.Text = rst.ToString();
        }

        private void tboxRst_TextChanged(object sender, EventArgs e)
        {
            tboxRstBit.Text = Convert.ToString(int.Parse(tboxRst.Text), 2);
        }

        private void btnrs_Click(object sender, EventArgs e)
        {
            int rst = 0;
            int tmp = int.Parse(tboxRst.Text);
            int num = int.Parse(tboxNum.Text);

            rst = tmp >> num;
            tboxRst.Text = rst.ToString();
        }

        private void btnse_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(tboxRst.Text);
            int num = int.Parse(tboxNum.Text);

            tmp += num;

            tboxRst.Text = tmp.ToString();
        }

        private void btnme_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(tboxRst.Text);
            int num = int.Parse(tboxNum.Text);

            tmp -= num;

            tboxRst.Text = tmp.ToString();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(tboxRst.Text);

            tboxRst.Text = (++tmp).ToString();
            tboxRstAfter.Text = tmp.ToString();
        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(tboxRst.Text);

            tboxRst.Text = (tmp++).ToString();
            tboxRstAfter.Text = tmp.ToString();
        }

        private void btnand_Click(object sender, EventArgs e)
        {
            int tmp1 = int.Parse(tboxRst.Text);
            int tmp2 = int.Parse(tboxRstAfter.Text);
            int num = int.Parse(tboxNum.Text);

            bool bRst = (tmp1 > num && tmp2 > num);

            tboxAo.Text = bRst.ToString();
        }

        private void btnor_Click(object sender, EventArgs e)
        {
            int tmp1 = int.Parse(tboxRst.Text);
            int tmp2 = int.Parse(tboxRstAfter.Text);
            int num = int.Parse(tboxNum.Text);

            bool bRst = (tmp1 > num || tmp2 > num);

            tboxAo.Text = bRst.ToString();
        }
    }
}