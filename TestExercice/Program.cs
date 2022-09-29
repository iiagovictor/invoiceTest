using System;

namespace TestExercice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo  , Diga abaixo , qual o Nome do produto:");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Bem vindo  , Diga abaixo , qual a descrição do Produto");
            string descricao = Console.ReadLine();
            Console.WriteLine("Bem vindo  , Diga abaixo , qual a quantidade do produto:");
            var quantidadeItens = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Bem vindo  , Diga abaixo , preço do produto:");
            var preco = Convert.ToInt16(Console.ReadLine());
            Invoice invoice = new Invoice(nomeProduto,descricao,quantidadeItens,preco);
            invoice.GetInvoiceAmount();
            Console.WriteLine("Para Fechar O App aperte qualquer botão");
            Console.ReadLine();
            
        }
    }
}
