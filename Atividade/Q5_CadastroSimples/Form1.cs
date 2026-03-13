namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome;
            int idade;

            nome = txtNome.Text;
            idade = Convert.ToInt32(txtIdade.Text);

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Idade = idade;

            listPessoas.Items.Add(pessoa.Nome + " - " + pessoa.Idade + " anos");
        }
    }
}
