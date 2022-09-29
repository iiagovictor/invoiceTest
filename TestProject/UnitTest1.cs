using TestExercice;
using Xunit;
using FluentAssertions;


namespace TestProject
{
    public class Test
    {
        [Fact]
        public void Muist_Get_Invoice_Amount_Sucesfuly()
        {
            Invoice invoice = new Invoice("Coca-Cola" , "Bebida" , 50 , 5);
            double Total = invoice.GetInvoiceAmount();
            //Verifica se o resultado é igual a total     
            Total.Equals(250);
        }

        [Fact]
        public void Invoice_Cannot_Have_Name_Empty()
        {
            Invoice invoice = new Invoice(string.Empty, "Bebida", 50, 5);
            var result = invoice.NameDescriptionAndProductQuantityAreEmpty(invoice.ItemName, invoice.Descricao, invoice.QuantidadeItens);
            invoice.ItemName.Should().Be("");
            result.Should().Be(false);
        }
        [Fact]
        public void Invoice_Cannot_Have_Description_Empty()
        {
            Invoice invoice = new Invoice("Coca-Cola", string.Empty, 50, 5);
            var result = invoice.NameDescriptionAndProductQuantityAreEmpty(invoice.ItemName, invoice.Descricao, invoice.QuantidadeItens);
            invoice.Descricao.Should().Be("");
            result.Should().Be(false);
        }
        [Fact]
        public void Invoice_Cannot_Have_Product_Quantity_Empty()
        {
            Invoice invoice = new Invoice("Coca-Cola", "Bebida", 0, 5);
            var result = invoice.NameDescriptionAndProductQuantityAreEmpty(invoice.ItemName, invoice.Descricao, invoice.QuantidadeItens);
            invoice.QuantidadeItens.Should().Be(0);
            result.Should().Be(false);
        }
        [Fact]
        public void Invoice_Cannot_Have_Product_Price_Lower_Than_Zero()
        {
            Invoice invoice = new Invoice("Coca-Cola", "Bebida", 0, -5);
            invoice.Message.Should().Match("O preço colocado é menor que zero");
        }
    }
}
