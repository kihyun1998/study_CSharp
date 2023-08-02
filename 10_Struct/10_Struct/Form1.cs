namespace _10_Struct
{



    public partial class Form1 : Form
    {
        struct sPlayer
        {
            public int iSun;
            public int iMoon;
            public int iStar;

            public int iSum;  //ÀüÃ¼ÇÕ
            public int iCnt;
        }

        sPlayer _stPlayer1;
        sPlayer _stPlayer2;
        Random _rd = new Random();



        //cPlayer _stPlayer1 = new cPlayer();
        //cPlayer _stPlayer2 = new cPlayer();

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

        cPlayer cPlayer = new cPlayer();    

        private void Rst()
        {
            string strRst = string.Empty;

            if (rbP1.Checked)
            {
                _stPlayer1.iCnt++;
                _stPlayer1.iSum = cPlayer.CardSum(
                        _stPlayer1.iSun,
                        _stPlayer1.iMoon,
                        _stPlayer1.iStar
                    );
                strRst = cPlayer.RstTxt(
                    _stPlayer1.iCnt,
                    _stPlayer1.iSun,
                    _stPlayer1.iMoon,
                    _stPlayer1.iStar,
                    _stPlayer1.iSum);
                lBoxRst1.Items.Add(strRst);
            }
            else
            {
                _stPlayer2.iCnt++;
                _stPlayer2.iSum = cPlayer.CardSum(
                        _stPlayer2.iSun,
                        _stPlayer2.iMoon,
                        _stPlayer2.iStar
                    );
                strRst = cPlayer.RstTxt(
                    _stPlayer2.iCnt,
                    _stPlayer2.iSun,
                    _stPlayer2.iMoon,
                    _stPlayer2.iStar,
                    _stPlayer2.iSum);
                lBoxRst2.Items.Add(strRst);
            }
            iChkChange();




            if (_stPlayer1.iCnt == _stPlayer2.iCnt)
            {
                lBoxNow.Items.Add(cPlayer.PlayerPair(
                    _stPlayer2.iCnt,
                    _stPlayer1.iSum,
                    _stPlayer2.iSum
                 ));

                if (_stPlayer2.iCnt >= 5)
                {
                    lBoxNow.Items.Add(cPlayer.PlayerRst(
                                _stPlayer1.iSum,
                                _stPlayer2.iSum
                        ));
                }
            }
        }
    }
}