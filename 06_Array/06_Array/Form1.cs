namespace _06_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayTest();
            ArrayClassTest();
        }


        private void ArrayTest()
        {
            int[] iArr1 = { 1, 2, 3, 4, 5 };

            int[] iArr2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] iArr3 = new int[5];
            iArr3[0] = 1;

            int[,] iArr4 = new int[2, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

        }

        private void ArrayClassTest()
        {
            int[] iArr = { 10, 20, 30, 40 };
            int i = iArr.Length;

            Array.Clear(iArr, 1, 2);
            Array.Resize(ref iArr, 10);
            int iSearch10 = Array.IndexOf(iArr, 10);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();
            int[] iVisitors = { 10, 40, 36, 27, 16, 84, 97 };

            lblArrCnt.Text = String.Format("전체 자료 수 : {0}",iVisitors.Length.ToString());

            dgDay["colDay1", 0].Value = iVisitors[0];
            dgDay["colDay2", 0].Value = iVisitors[1];
            dgDay["colDay3", 0].Value = iVisitors[2];
            dgDay["colDay4", 0].Value = iVisitors[3];
            dgDay["colDay5", 0].Value = iVisitors[4];
            dgDay["colDay6", 0].Value = iVisitors[5];
            dgDay["colDay7", 0].Value = iVisitors[6];
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();
            int[,] iVisitors = {{ 10, 40, 36, 27, 16, 84, 97 },{ 120, 430, 346, 257, 616, 884, 997 } };
            lblArrCnt.Text = String.Format("전체 자료 수 : {0}", iVisitors.Length.ToString());
            dgDay.Rows.Add();
            dgDay["colDay1", 0].Value = iVisitors[0,0];
            dgDay["colDay2", 0].Value = iVisitors[0,1];
            dgDay["colDay3", 0].Value = iVisitors[0,2];
            dgDay["colDay4", 0].Value = iVisitors[0,3];
            dgDay["colDay5", 0].Value = iVisitors[0,4];
            dgDay["colDay6", 0].Value = iVisitors[0,5];
            dgDay["colDay7", 0].Value = iVisitors[0,6];

            dgDay["colDay1", 1].Value = iVisitors[1, 0];
            dgDay["colDay2", 1].Value = iVisitors[1, 1];
            dgDay["colDay3", 1].Value = iVisitors[1, 2];
            dgDay["colDay4", 1].Value = iVisitors[1, 3];
            dgDay["colDay5", 1].Value = iVisitors[1, 4];
            dgDay["colDay6", 1].Value = iVisitors[1, 5];
            dgDay["colDay7", 1].Value = iVisitors[1, 6];
        }
    }
}