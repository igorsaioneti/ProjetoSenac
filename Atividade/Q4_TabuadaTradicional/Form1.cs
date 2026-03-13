namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int tabuada;
           tabuada = Convert.ToInt32(txtNumero.Text);

            for (int i = 0; i <= 10; i++) {
                listTabuada.Items.Add($"{tabuada} x {i} = {tabuada * i} ");
                
            }
            
    }
}
    }