namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double celsius, fahrenheit;

            celsius = Convert.ToDouble(txtCelsius.Text);
            fahrenheit = (celsius * 9 / 5) + 32;
            lblResultado.Text = fahrenheit.ToString();
        }
    }
}
