namespace study_Thread
{
    public partial class Form1 : Form
    {
        private enum enumPlayer
        {
            일번,
            이번,
            삼번,
            사번,
            오번,
        }

        int _lx = 0;
        int _ly = 0;
        List<Play> lplay = new List<Play>();    

        public Form1()
        {
            InitializeComponent();

            _lx = this.Location.X;
            _ly = this.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _lx = this.Location.X + this.Size.Width;
            _ly = this.Location.Y;

            for (int i = 0; i < nPlayerCnt.Value; i++)
            {
                Play f1 = new Play(((enumPlayer)i).ToString());
                f1.StartPosition = FormStartPosition.Manual;
                f1.Location = new Point(_lx, _ly + f1.Height * i);

                f1.eventdelMsg += F1_eventdelMsg;
                f1.Show();
                f1.fThreadStart();
                lplay.Add(f1);  
            }
        }

        private int F1_eventdelMsg(object sender, string strRst)
        {

            if (this.InvokeRequired) // 요청 thread가 현재 Main Thread 있는 Control을 접근할 수 있는지 확인
            {
                this.Invoke(new Action(delegate () //Main Thread
                {

                    Play oPlayer = sender as Play;
                    lBoxRst.Items.Add(string.Format("Player : {0}, Resert : {1}", oPlayer.SPlayerName, strRst));

                }));
            }
            return 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var p in lplay)
            {
                p.ThreadJoin();
                p.ThreadInterrupt();
            }
        }
    }
}