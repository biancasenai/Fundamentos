using Fundamentos;

internal class Program
{


    private static void Main(string[] args)
    {
        //exemplo de coemtario em uma linha

        //Livro Livro1 = new Livro();
        /*Livro1.Titulo = "Harry POtter";
        Livro1.Editora = "Editora Abril";
        Livro1.Autor = "J.K.H";
        Livro1.AnoLancamento = 2001;

        Livro livro2 = new Livro();
        livro2.Titulo = "Programando em C#";
        livro2.Editora = "Editora Nova";
        livro2.Autor = "Gustavo Castello";
        livro2.AnoLancamento = 1982;

        Livro livro3 = new Livro();
        livro3.Titulo = "Pai Rico Pai Pobre";
        livro3.Editora = "Minha Editora";
        livro3.Autor = "Cristiano de Paula";
        livro3.AnoLancamento = 2000;*
    }
}

// instanciar um objeto do tipo Aluno
Aluno aluno1 = new Aluno();
Aluno aluno2 = new Aluno(); 

// preencher os atributos do objeto
aluno1.Nome = "Cristiano de Paula";
aluno1.RM = "1234TI";
aluno1.Email = "cristiano.paula@sp.senai.br";
aluno1.Nascimento = new DateOnly(1981, 07, 16);

aluno2.Nome = "Helena Maria";
aluno2.RM = "4321TI";
aluno2.Email = "helena.maria@sp.senai.br";
aluno2.Nascimento = new DateOnly(2001, 06, 17);

//imprimit na tela
Console.WriteLine("aluno 1");
Console.WriteLine("Nome: " + aluno1.Nome);
Console.WriteLine("=====================================");
Console.WriteLine("Email" + aluno1.Email);
Console.WriteLine("======================================");

Console.WriteLine("aluno 2");
Console.WriteLine("Nome: " + aluno2.Nome);
Console.WriteLine("=======================================");
Console.WriteLine("Email" + aluno2.Email);
Console.WriteLine("=======================================");

//instanciar um objeto do tipo produto
Produto p1 = new Produto();
p1.Codigo = 123456;
p1.Nome = "Coca-cola 2 litros";
p1.Preco = 12.99;
p1.Estoque = 69;
//Chamar o metodo QuantidadeEstoque
p1.QuantidadeEstoque();
p1.Estoque = 85;
//Chamar o metodo QuantidadeEstoque
p1.QuantidadeEstoque();

Console.WriteLine("================================")
Console.WriteLine();

//instanciar um objeto de tipo Carro
Carro.carro1 = new Carro();
carro1.Marca = "Ferrari";
carro1.Modelo = "488";
carro1.Velocidade = 80;

carro1.Acelerar();
carro1.Acelerar();
carro1.Acelerar();
carro1.Desacelerar();

Console.WriteLine("================================");
Console.WriteLine();

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "José";
pessoa1.Idade = 18;

pessoa1.Envelhecer(5);
pessoa1.Envelhecer(2);

 
Console.WriteLine("================================");
Console.WriteLine();

Funcionario func1 = new Funcionario();
func1.Nome = "Luis Santos";
func1.Idade = "20";
func1.Cargo = "Aprendiz";
func1.Salario = 1400.00



Console.WriteLine("================================");
Console.WriteLine();

//intanciar um objeto
Animal animal1 = new Animal();

//inserindo dados no atributo
animal1 Especie = "Cachorro";

//chamando o metodo do objeto
animal1 emitirSom();

//
Console.WriteLine("o Animal " + animal1.Especie + "emitiu um som");*/

        Gato gato = new Gato();
        gato.Nome = "Frajola";
        Console.WriteLine(gato.Nome);
        gato.emitirSom();

        Console.WriteLine();
        Galinha galinha = new Galinha();
        galinha.Nome = "Judite";
        Console.WriteLine(galinha.Nome);
        galinha.emitirSom();

        Console.WriteLine();
        Porco porco = new Porco();
        porco.Nome = "Bacon";
        Console.WriteLine(porco.Nome);
        porco.emitirSom();


    }
}






