// ./Estudante.cs

//---> Questão 3:

public class Estudante
{
    public string Matricula { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Estudante(string Matricula, string Nome, int Idade){
        this.Matricula = Matricula;
        this.Nome = Nome;
        this.Idade = Idade;
    }

}