using System.Text;

namespace _09_for2_Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhileRst_Click(object sender, EventArgs e)
        {
            int[] iArr = new int[6];
            int iCnt = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            while (Array.IndexOf(iArr, 0) != -1)
            {
                int iNum = rd.Next(1, 46);
                if (Array.IndexOf(iArr, iNum) == -1)
                {
                    iArr[iCnt] = iNum;
                    iCnt++;
                }
            }
            Array.Sort(iArr);
            foreach (int iNum in iArr)
            {
                sb.Append(String.Format("{0}. ", iNum));
            }

            lblWhileRst.Text = sb.ToString();
            lBoxWhileRst.Items.Add(sb.ToString());
        }

        private void btnDoWhileRst_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int iNum = int.Parse(tBoxNum.Text);

            if (iNum < 1 || iNum > 100)
            {
                MessageBox.Show("�� 1 ���� 100 ������ ���ڸ� �Է����ּ���!");
                return;
            }
            
            int iChk = 0;
            int iCnt = 0;

            do
            {
                iChk = rd.Next(1, 101);
                iCnt++;

            } while (iNum != iChk);

            lblDoWhileRst.Text = string.Format("���� ���� {0}�� {1}ȸ���� ã�ҽ��ϴ�.", iNum, iCnt);
        }
    }
}