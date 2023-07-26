using System.Text;

namespace _08_for1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            tBoxRst.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            int iRst = 0;

            for (int i = 0; i < 100; i++)
            {
                iRst += i;
                sb.Append(string.Format("1부터 {0}까지 더한 값은 {1} \r\n", i, iRst));
            }

            tBoxRst.Text = sb.ToString();
        }

        private void bntForEach_Click(object sender, EventArgs e)
        {
            tBoxRst.Text = string.Empty;
            StringBuilder sb = new StringBuilder();
            string[] strArr = { "A+", "A0", "A-", "B+", "B0", "B-", "C+", "C0", "C-", "D+", "D0", "D-", "F" };

            int iCnt = 0;
            foreach (string str in strArr) 
            {
                iCnt++;
                sb.Append(string.Format("{0} 학점은 {1}명입니다.\r\n", str,iCnt));
            }
            tBoxRst.Text += sb.ToString();  
        }
    }
}