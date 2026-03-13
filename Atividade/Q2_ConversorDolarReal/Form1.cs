namespace Q2_ConversorDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double dolares, quantidade, reais;

            dolares = Convert.ToDouble(txtCotacao.Text);
            quantidade = Convert.ToDouble(txtDolares.Text);
            reais = dolares * quantidade;
            lblResultado.Text = reais.ToString();

        }
    }
}
