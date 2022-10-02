namespace oef5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctof_Click(object sender, EventArgs e)
        {
            

            int celcius = int.Parse(celciusnumber.Text);

            double fahrenheit = (double)celcius * 9 / 5 + 32;

            fahrenheitnumber.Text = fahrenheit.ToString();
            
            

            
        }

        private void fahrenheitnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void ftoc_Click(object sender, EventArgs e)
        {
            int fahrenheit = int.Parse(fahrenheitnumber.Text);

            double celcius = ((double)fahrenheit - 32) * 5 / 9;

            celciusnumber.Text = celcius.ToString();


        }
    }
}