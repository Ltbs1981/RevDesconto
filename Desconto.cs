using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevDesconto
{
    public class Desconto
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public Desconto(string nome, int quantidade, double preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }
        public double CalculandoDesconto()
        {
            return Preco * Quantidade;
        }
    }
}
