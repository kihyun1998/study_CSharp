namespace _01_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = lblText.Text;

            lblContain.Text = txt.Contains("Text").ToString();
            lblEquals.Text = txt.Equals("Text").ToString();
            lblLength.Text = txt.Length.ToString();
            lblReplace.Text = txt.Equals("Text").ToString();

            string[] txtSplit = txt.Split(' ');
            lblSplit1.Text = txtSplit[0];
            lblSplit2.Text = txtSplit[1];
            lblSplit3.Text = txtSplit[2];
            lblSplit4.Text = txtSplit[3];

            lblSubstring.Text = txt.Substring(3, 5);
            lblToLower.Text = txt.ToLower();
            lblToUpper.Text = txt.ToUpper();
            lblTrim.Text = txt.Trim();
        }
    }
}