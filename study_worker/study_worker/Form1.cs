namespace study_worker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 10;
            backgroundWorker1.RunWorkerAsync();
            //for (int i = 1; i <= 10; i++)
            //{
            //    Thread.Sleep(1000);
            //    progressBar1.Value += 1;
            //}
            //MessageBox.Show("Completed");
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {  
            for(int i = 0; i < 10; i++)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(1000);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value += 1;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Completed");
        }
    }
}