using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Arthur", sobrenome: "Duarte");

Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");


Curso cursoDeInglês = new Curso();
cursoDeInglês.Nome = "Inglês";
cursoDeInglês.Alunos = new List<Pessoa>();


cursoDeInglês.AdicionarAluno(p1);
cursoDeInglês.AdicionarAluno(p2);
cursoDeInglês.ListarAlunos();
















/* p1.Nome = "Arthur";
p1.Sobrenome = "Duarte";
p1.Idade = 38;
p1.Apresentar(); */


/* Um jeito melhor

Pessoa p1 = new Pessoa
{
    Nome = "Arthur",
    Idade = 38
}
p1.Apresentar(); 

//Ou abaixo

Pessoa p1 = new()
{
    Nome = "Arthur",
    Idade = 38
};
p1.Apresentar();


*/


