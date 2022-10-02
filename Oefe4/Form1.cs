namespace Oefe4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double shippingg = 5.00;
            double tax = 0.10;



             double priceone = double.Parse(price1.Text);
             double pricetwo = double.Parse(price2.Text);
             double pricethree = double.Parse(price3.Text);
             double pricefour = double.Parse(price4.Text);


            int quantity1 = Convert.ToInt32(qty1.Value);
            int quantity2 = Convert.ToInt32(qty2.Value);
            int quantity3 = Convert.ToInt32(qty3.Value);
            int quantity4 = Convert.ToInt32(qty4.Value);




            double totaalone = quantity1*priceone;
            double totaaltwo = quantity2*pricetwo;
            double totaalthree = quantity3*pricethree;
            double totaalfour = quantity4 *pricefour;


            double Subtotaal = totaalone + totaaltwo + totaalthree + totaalfour;
            double SalesTax = Subtotaal *tax;
            double Grandtotaal = Subtotaal + tax + shippingg;

            totaal1.Text = "€" + totaalone;
            totaal2.Text = "€" + totaaltwo;
            totaal3.Text = "€" + totaalthree;
            totaal4.Text = "€" + totaalfour;




            subtotaal.Text = "€" + Subtotaal;
            taxrate.Text = tax.ToString();
            salestax.Text = "€" + SalesTax;
            shipping.Text  =  "€" + shippingg;
            grandtotaal.Text = "€" + Grandtotaal;








        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}