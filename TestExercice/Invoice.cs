using System;
using System.Collections.Generic;
using System.Text;

namespace TestExercice
{
    public class Invoice
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeItens { get; set; }
        public double Preco { get; set; }
        public string Message { get; set; }

        public Invoice(string itemName, string descricao, int quantidadeItens, double preco)
        {
            ItemId++;
            ItemName = itemName;
            Descricao = descricao;
            QuantidadeItens = quantidadeItens;
            Preco = preco;
            if(preco < 0 )
            {
                preco = 0;
                Message = "O preço colocado é menor que zero";
            }
        }
        public Double GetInvoiceAmount()
        {
            double total = QuantidadeItens * Preco;
            Console.WriteLine($"O valor total da quantidade de ´produtos é de {total}");
            return total;
        }

        public bool NameDescriptionAndProductQuantityAreEmpty(string itemName , string descricao, int quantidadeItens)
        {
            if(itemName == "")
            {
                return false;
                Console.WriteLine("O nome do Produto não pode ser vazio");
            }
            else if(descricao == "")
            {
                return false;
                Console.WriteLine("A descrição do Produto não pode ser vazia");
            }
            else if(quantidadeItens == 0)
            {
                return false;
                Console.WriteLine("A quantidade de itens do Produto não pode ser nula");
            }
                return true;
        }
    }
}
