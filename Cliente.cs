// ./Cliente.cs

public class Cliente {
    public string Cpf {get;set;}
    public string Nome {get;set;}

    public Cliente(string cpf, string nome)
    {
        this.Cpf = cpf;
        this.Nome = nome;
    }
} 