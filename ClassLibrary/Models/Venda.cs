namespace ClassLibrary.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        // Sobrescrevendo o método ToString
        public override string ToString()
        {
            return $"ID: {Id}, Produto: {Produto}, Preço: {Preco}, Data de Venda: {DataVenda.ToShortDateString()}";
        }
    }
}
