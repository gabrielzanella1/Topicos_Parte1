public class Pedido
{
    public string Data { get; set; }
    public Cliente Cliente { get; set; }
    public Vendedor Vendedor {get;set;}
    public List<Produto> produtos {get;set;}

    public Pedido(Cliente cliente, Vendedor vendedor, string data)
    {
        this.Cliente = cliente;
        this.Vendedor = vendedor;
        this.Data = data;
        this.produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

      public List<Produto> GetProdutos()
    {
        return this.produtos;
   }
} 