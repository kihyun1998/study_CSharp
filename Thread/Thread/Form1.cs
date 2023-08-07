namespace study_Thread
{
    public partial class Form1 : Form
    {
        private enum enumPlayer
        {
            �Ϲ�,
            �̹�,
            ���,
            ���,
            ����,
        }

        int lx = 0;
        int ly = 0;

        public Form1()
        {
            InitializeComponent();
            lx = this.Location.X;
            ly = this.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lx = this.Location.X + this.Size.Width;
            ly = this.Location.Y;

            for(int i=0; i < nPlayerCnt.Value; i++)
            {
                Play f1 = new Play(((enumPlayer)i).ToString());
                f1.Location = new Point(lx, ly + f1.Height * i);

                f1.eventdelMsg += F1_eventdelMsg;
                f1.Show();
                f1.fThreadStart();
            }
        }

        private int F1_eventdelMsg(object sender, string strRst)
        {

            if (this.InvokeRequired) // ��û thread�� ���� Main Thread �ִ� Control�� ������ �� �ִ��� Ȯ��
            {
                this.Invoke(new Action(delegate () //Main Thread
                {

                    Play oPlayer = sender as Play;
                    lBoxRst.Items.Add(string.Format("Player : {0}, Resert : {1}", oPlayer.SPlayerName, strRst));

                }));
            }
            return 0;
        }
    }
}