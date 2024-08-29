using RevDesconto;
class Program
{
    static void Main(string[] args) 
    {
        Desconto desconto = new Desconto("IPhone 12", 20, 4000);

        double valor = desconto.CalculandoDesconto();
        Console.WriteLine($"Você está comprando: \n Produto: {desconto.Nome}. \n Quantidades: {desconto.Quantidade} .\n Valor unitário: R$ {desconto.Preco}.\n Total sem desconto: R$ {valor}\n \n");
        
        if(desconto.Quantidade >= 11 && desconto.Quantidade<= 20)
        {
            valor -= 0.10 * valor;
            Console.WriteLine($"Devido ao seu desconto por ter comprado mais de 10 unidades,\n Pagará R$ {valor} ");
        }else if (desconto.Quantidade >= 21 && desconto.Quantidade <= 50)
        {
            valor -= 0.20 * valor;
            Console.WriteLine($"Devido ao seu desconto por ter comprado mais de 20 unidades,\n Pagará R$ {valor} ");
        }else if (desconto.Quantidade > 50 )
        {
            valor -= 0.25 * valor;
            Console.WriteLine($"Devido ao seu desconto por ter comprado mais de 50 unidades,\n Pagará R$ {valor} ");
        }



    }
}