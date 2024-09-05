using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevDesconto
{
    public class Desconto
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        private double _preco;
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

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
