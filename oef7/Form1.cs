using System.DirectoryServices.ActiveDirectory;

namespace oef7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {

            int Number = int.Parse(textbox1.Text);


            int[] listofnumbers = new int[Number];

            int totaal = 0;

            for (int i = 0; i < Number; i++)
            {
                listofnumbers[i] = i + 1;

            }

            for (int i = 0; i < listofnumbers.Length; i++)
            {
                totaal = totaal + listofnumbers[i];
            }

            result.Text = totaal.ToString();




        }
    }
}