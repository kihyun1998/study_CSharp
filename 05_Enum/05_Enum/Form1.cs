namespace _05_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum eDay
        {
            Monday,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        private enum eTime
        {
            Morning,
            Lunch,
            Afternoon,
            Dinner,
            Night
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lBoxDay.Items.Add(eDay.Monday);
            lBoxDay.Items.Add(eDay.Thuesday);
            lBoxDay.Items.Add(eDay.Wednesday);
            lBoxDay.Items.Add(eDay.Thursday);
            lBoxDay.Items.Add(eDay.Friday);
            lBoxDay.Items.Add(eDay.Saturday);
            lBoxDay.Items.Add(eDay.Sunday);

            lBoxTime.Items.Add(eTime.Morning);
            lBoxTime.Items.Add(eTime.Lunch);
            lBoxTime.Items.Add(eTime.Afternoon);
            lBoxTime.Items.Add(eTime.Dinner);
            lBoxTime.Items.Add(eTime.Night);

        }

        private void btnRst1_Click(object sender, EventArgs e)
        {
            string strRst = tBoxName.Text + "와 " + lBoxDay.SelectedItem.ToString() + " " + lBoxTime.SelectedItem.ToString() + "에 본다.";
            tBoxRst.Text = strRst;
        }

        private void btnRst2_Click(object sender, EventArgs e)
        {
            string strRst = String.Format("{0}와 {1} {2}에 본다.",
                tBoxName.Text,
                lBoxDay.SelectedItem.ToString(),
                lBoxTime.SelectedItem.ToString());
            tBoxRst.Text = strRst;
        }
    }
}