//------ Questão 2 ------> 
Pessoa pessoa1 = new Pessoa();
pessoa1.Cpf = "7126379123-1";
pessoa1.Nome = "Marcio";

Livro livro1 = new Livro();
livro1.Titulo = "Iniciando em C#";
livro1.Autor = "Paulo Ricardo";
pessoa1.adicionarLivros(livro1);

Livro livro2 = new Livro();
livro2.Titulo = "Iniciando em Java";
livro2.Autor = "Murilo Santos";
pessoa1.adicionarLivros(livro2);

List<Livro> livrosp1 = pessoa1.GetLivros();

Console.WriteLine("<------ Questão 2 ------> ");
Console.WriteLine("Dados dos livros: ");

foreach (Livro livro in livrosp1){
    Console.WriteLine($"Titulo: {livro.Titulo}, Autor: {livro.Autor}");
}

Console.WriteLine();

//------ Questão 3 ------> 
Estudante estudante1 = new Estudante("40028922", "Yuri dos Santos", 20);

Console.WriteLine("<------ Questão 3 ------> ");
Console.WriteLine($"Matrícula: {estudante1.Matricula}, Nome: {estudante1.Nome}, Idade: {estudante1.Idade}.");
Console.WriteLine();

//------ Questão 4 ------> 
Cliente cliente1 = new Cliente("1234567891", "Cleusa");
Pedido pedido1 = new Pedido(cliente1, "23/04/2024");

Console.WriteLine("<------ Questão 4 ------> ");
Console.WriteLine($"CPF: {pedido1.Cliente.Cpf}, Nome: {pedido1.Cliente.Nome}, Data do Pedido: {pedido1.Data}.");

//------- Desafio -------> 

Cliente cliente2 = new Cliente("126793962713", "Jonas");
Vendedor vendedor1 = new Vendedor("4716212764", "Guzmán");
Pedido pedido2 = new Pedido(cliente2, vendedor1, "12/12/2012");
Produto produto1 = new Produto("Macarrão", 109.90);
Produto produto2 = new Produto("Mignon", 179.90);
pedido2.AdicionarProduto(produto1);
pedido2.AdicionarProduto(produto2);

List<Produto> produtos = pedido2.GetProdutos();

Console.WriteLine("------- Desafio ------->");

Console.WriteLine("Nome do Cliente: " + cliente2.Nome);
Console.WriteLine("Nome do Vendedor: " + vendedor1.Nome);
Console.WriteLine("Data do Pedido: " + pedido2.Data);

foreach (Produto produto in produtos){
    Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}.");
}













