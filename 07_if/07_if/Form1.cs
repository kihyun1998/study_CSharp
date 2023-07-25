namespace _07_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIfRst_Click(object sender, EventArgs e)
        {
            int inum1 = (int)nNum1.Value;
            int inum2 = (int)nNum2.Value;

            if (inum1 > inum2)
            {
                lblIfRst.Text = String.Format("Num1�� Num2���� {0}��ŭ �� ũ��.", inum1 - inum2);
            }
            else if (inum1 < inum2)
            {
                lblIfRst.Text = String.Format("Num2�� Num1���� {0}��ŭ �� ũ��.", inum2 - inum1);
            }
            else
            {
                lblIfRst.Text = String.Format("�����ϴ�. ���� : {0}", inum1);
            }
        }

        private void btnSwRst_Click(object sender, EventArgs e)
        {
            string strSel = cBoxDay.Text;

            switch(strSel)
            {
                case "��":
                    lblSwRst.Text = String.Format("������ ��¥�� �������Դϴ�.");
                    break;
                case "ȭ":
                    lblSwRst.Text = String.Format("������ ��¥�� ȭ�����Դϴ�.");
                    break;
                case "��":
                    lblSwRst.Text = String.Format("������ ��¥�� �������Դϴ�.");
                    break;
                case "��":
                    lblSwRst.Text = String.Format("������ ��¥�� ������Դϴ�.");
                    break;
                case "��":
                    lblSwRst.Text = String.Format("������ ��¥�� �ݿ����Դϴ�.");
                    break;
                case "��":
                case "��":
                    lblSwRst.Text = String.Format("������ ��¥�� �ָ��Դϴ�.");
                    break;
                default:
                    lblSwRst.Text = String.Format("����");
                    break;

            }
        }
    }
}