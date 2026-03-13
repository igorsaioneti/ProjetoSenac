namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia, passagem;
            distancia = Convert.ToDouble(txtDistancia.Text);

            if (distancia <= 200)
            {
                passagem = distancia * 0.5;
            }
            else
            {
                passagem = distancia * 0.45;
            }
            lblResultado.Text = passagem.ToString();
        }
    }
}