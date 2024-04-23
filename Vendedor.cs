// ./Vendedor.cs

public class Vendedor{
    public string Cpf {get;set;}
    public string Nome {get;set;}

    public Vendedor(string Cpf, string Nome){
        this.Cpf = Cpf;
        this.Nome = Nome;
    }
}