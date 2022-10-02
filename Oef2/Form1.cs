namespace Oef2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int berekeningeen = 12345 * 54321;
            int berekeningtwee = 22222 * 33333;
            int Result1 = berekeningeen;
            int Result2 = berekeningtwee;


            bool check = Result1 > Result2;


            string brk1 = "12345 * 54321";
            string brk2 = " 22222 * 33333";
            string brk3 = "12345 * 54321  >  22222 * 33333  ";
            string uitkomst1 = $"{berekeningeen}";
            string uitkomst2 = $"{berekeningtwee}";



            berekening1.Text = brk1;
            berekening2.Text = brk2;

            result1.Text = uitkomst1;
            result2.Text = uitkomst2;
            compare.Text = brk3 +  " =  " + check;
           





        }

        private void berekening1_Click(object sender, EventArgs e)
        {

        }
    }
}