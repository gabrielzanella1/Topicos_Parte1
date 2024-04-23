// ./Pessoa.cs

//---> Questão 2:



public class Pessoa {
   public string Cpf {get; set;}

   public string Nome {get; set;}

   public List<Livro> livros = new List<Livro>();

   public void adicionarLivros(Livro livro){
        this.livros.Add(livro);
   }

   public List<Livro> GetLivros()
    {
        return this.livros;
   }
}