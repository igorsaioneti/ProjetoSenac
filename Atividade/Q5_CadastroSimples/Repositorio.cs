using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_CadastroSimples
{
    internal class Repositorio
    {
        public List<Pessoa> lista = new List<Pessoa>();
        public void Adicionar(Pessoa pessoa)
        {
            lista.Add(pessoa);
        }
    }
}
