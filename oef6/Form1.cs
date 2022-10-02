using System.Transactions;

namespace oef6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double tax = 0.07;
            double shipping = 0.0;


            int quantity1 = int.Parse(textBox9.Text);
            int quantity2 = int.Parse(textBox10.Text);
            int quantity3 = int.Parse(textBox11.Text);
            int quantity4 = int.Parse(textBox12.Text);

            double priceone = int.Parse(textBox5.Text);
            double pricetwo = int.Parse(textBox6.Text);
            double pricethree = int.Parse(textBox7.Text);
            double pricefour = int.Parse(textBox8.Text);



            double totaal1 = priceone * quantity1;
            double totaal2 = pricetwo * quantity2;
            double totaal3 = pricethree * quantity3;
            double totaal4 = pricefour * quantity4;

            double subtotaal = totaal1+totaal2+totaal3+totaal4;


            if(subtotaal < 20)
            {
                shipping = 5.00;
            }
            else if( subtotaal >= 20 && subtotaal < 50)
            {
                shipping =  7.5;
            }
            else if( subtotaal >= 50 && subtotaal < 75)
            {
                shipping =10.00;
            }
            else if(subtotaal >= 75)
            {
                shipping =  0;
            }
            double salestax = subtotaal * tax;
            double grandtotaal = subtotaal + salestax + shipping;


            textBox13.Text = "€" + totaal1;
            textBox14.Text = "€" + totaal2;
            textBox15.Text = "€" + totaal3;
            textBox16.Text = "€" + totaal4;

            textBox17.Text ="€" + subtotaal;
            textBox18.Text ="€" + salestax;
            textBox19.Text ="€" +shipping;
            textBox20.Text ="€" + grandtotaal;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}