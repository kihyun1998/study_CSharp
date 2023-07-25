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
                lblIfRst.Text = String.Format("Num1이 Num2보다 {0}만큼 더 크다.", inum1 - inum2);
            }
            else if (inum1 < inum2)
            {
                lblIfRst.Text = String.Format("Num2가 Num1보다 {0}만큼 더 크다.", inum2 - inum1);
            }
            else
            {
                lblIfRst.Text = String.Format("같습니다. 숫자 : {0}", inum1);
            }
        }

        private void btnSwRst_Click(object sender, EventArgs e)
        {
            string strSel = cBoxDay.Text;

            switch(strSel)
            {
                case "월":
                    lblSwRst.Text = String.Format("선택한 날짜는 월요일입니다.");
                    break;
                case "화":
                    lblSwRst.Text = String.Format("선택한 날짜는 화요일입니다.");
                    break;
                case "수":
                    lblSwRst.Text = String.Format("선택한 날짜는 수요일입니다.");
                    break;
                case "목":
                    lblSwRst.Text = String.Format("선택한 날짜는 목요일입니다.");
                    break;
                case "금":
                    lblSwRst.Text = String.Format("선택한 날짜는 금요일입니다.");
                    break;
                case "토":
                case "일":
                    lblSwRst.Text = String.Format("선택한 날짜는 주말입니다.");
                    break;
                default:
                    lblSwRst.Text = String.Format("에러");
                    break;

            }
        }
    }
}