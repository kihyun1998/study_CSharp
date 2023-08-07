using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace study_Thread
{
    public partial class Play : Form
    {
        public delegate int delMsg(object sender, string strRst);
        public event delMsg eventdelMsg;

        string _sPlayerName = string.Empty;
        public string SPlayerName { get => _sPlayerName; set => _sPlayerName = value; }

        Thread _thread = null;

        

        public Play()
        {
            InitializeComponent();
        }
        public Play(string strPlayerName)
        {
            InitializeComponent();
            lbPlayerName.Text = SPlayerName = strPlayerName;
        }

        public void fThreadStart()
        {
            // 1. 델리게이트 타입 객체를 생성 후 함수를 넘긴다.
            _thread = new Thread(new ThreadStart(Run));

            // 2. 컴파일러에서 델리게이터 객체를 추론생성해서 함수를 넘기는 방법.
            //_thread = new Thread(Run);

            // 3. 익명 메소드라는 것
            //_thread = new Thread(delegate () { Run(); });

            _thread.Start();
        }

        private void Run()
        {

            // 크로스 쓰레드 발생 원인
            // UI Control이 자신이 만들어진 Thread가 아닌 다른 Thread에서 접근할 경우 Cross Thread발생


            int ivar = 0;
            Random rd = new Random();

            while (pBar.Value < 100)
            {
                if (this.InvokeRequired) // 요청 thread가 현재 Main Thread 있는 Control을 접근할 수 있는지 확인
                {
                    this.Invoke(new Action(delegate () //Main Thread
                    {

                        ivar = rd.Next(1, 11);
                        if (pBar.Value + ivar > 100)
                        {
                            pBar.Value = 100;
                        }
                        else
                        {
                            pBar.Value = pBar.Value + ivar;
                        }
                        lblProgress.Text = string.Format("진행 상황 표시 : {0}%", pBar.Value);
                        this.Refresh();

                    }));
                    Thread.Sleep(300);
                }
            }
            eventdelMsg(this, "Clear");
        }

        public void test()
        {
            int ivar = 0;
            Random rd = new Random();

            while (pBar.Value < 100)
            {
                ivar = rd.Next(1, 11);
                if (pBar.Value + ivar > 100)
                {
                    pBar.Value = 100;
                }
                else
                {
                    pBar.Value = pBar.Value + ivar;
                }
                lblProgress.Text = string.Format("진행 상황 표시 : {0}%", pBar.Value);
                this.Refresh();
                Thread.Sleep(300);
            }
        }
    }
}
