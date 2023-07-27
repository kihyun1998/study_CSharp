namespace _10_Struct
{
    public partial class Form1 : Form
    {
        struct sPlayer
        {
            public int iSun;
            public int iMoon;
            public int iStar;

            public int iCnt;  //회
            public int iSum;  //전체합

            public int CardSum(int iSun, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            public string RstTxt(int iSum)
            {
                return string.Format("{0}회 진행 : 해: {1} 달: {2} 별: {3} ==>> 합계는 {4}입니다.",
                                      iCnt, iSun, iMoon, iStar, iSum);
            }
        }

        sPlayer _stPlayer1;
        sPlayer _stPlayer2;
        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pBoxSun_Click(object sender, EventArgs e)
        {
            int iNum = _rd.Next(1, 21);

            if (rbP1.Checked)
            {
                _stPlayer1.iSun = iNum;
            }
            else
            {
                _stPlayer2.iSun = iNum;
            }
            Rst();
        }

        private void pBoxMoon_Click(object sender, EventArgs e)
        {
            int iNum = _rd.Next(1, 21);

            if (rbP1.Checked)
            {
                _stPlayer1.iMoon = iNum;
            }
            else
            {
                _stPlayer2.iMoon = iNum;
            }
            Rst();
        }

        private void pBoxStar_Click(object sender, EventArgs e)
        {
            int iNum = _rd.Next(1, 21);

            if (rbP1.Checked)
            {
                _stPlayer1.iStar = iNum;
            }
            else
            {
                _stPlayer2.iStar = iNum;
            }
            Rst();
        }

        private void pBoxNone_Click(object sender, EventArgs e)
        {
            Rst();
        }

        private void iChkChange()
        {
            if (rbP1.Checked)
            {
                rbP2.Checked = true;
            }
            else
            {
                rbP1.Checked = true;
            }
        }

        private void Rst()
        {
            string strRst = string.Empty;

            if (rbP1.Checked)
            {
                _stPlayer1.iCnt++;
                _stPlayer1.iSum = _stPlayer1.CardSum(
                        _stPlayer1.iSun,
                        _stPlayer1.iMoon,
                        _stPlayer1.iStar
                    );
                strRst = _stPlayer1.RstTxt(_stPlayer1.iSum);
                lBoxRst1.Items.Add(strRst);
            }
            else
            {
                _stPlayer2.iCnt++;
                _stPlayer2.iSum = _stPlayer2.CardSum(
                        _stPlayer2.iSun,
                        _stPlayer2.iMoon,
                        _stPlayer2.iStar
                    );
                strRst = _stPlayer2.RstTxt(_stPlayer2.iSum);
                lBoxRst2.Items.Add(strRst);
            }
            iChkChange();

            if(_stPlayer1.iCnt >= 5 && _stPlayer2.iCnt >=5)
            {
                if (_stPlayer1.iSum > _stPlayer2.iSum)
                {
                    MessageBox.Show("Player1 win");
                }
                else if(_stPlayer1.iSum < _stPlayer2.iSum) 
                {
                    MessageBox.Show("Player2 win");
                }
                else
                {
                    MessageBox.Show("Draw");
                }
            }
        }
    }
}