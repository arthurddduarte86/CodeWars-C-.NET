using ExemploExplorando.Models;



LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, LinhasDoArquivo, quantidadeDeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine("Quantidade total de linhas: " + quantidadeDeLinhas);
    foreach(string linha in LinhasDoArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}








/* 
//trabalhando com TUPLAS

//Uma forma de declarar tuplas
(int Id, string Nome, string Sobrenome, decimal Altura) minhaTupla = (1, "Arthur", "Duarte", 1.80M);

//segunda forma de declarar tuplas
ValueTuple<int, string, string, decimal> outraTupla = (2, "José", "Silva", 1.70M);

//esta forma de criar reconhece os tipos pela atribuição de valores
var maisOutraTupla = Tuple.Create(3, "Carlos", "Antunes", 1.80M); 


Console.WriteLine($"ID: {minhaTupla.Id}");
Console.WriteLine($"Nome: {minhaTupla.Nome}");
Console.WriteLine($"Sobrenome: {minhaTupla.Sobrenome}");
Console.WriteLine($"Altura: {minhaTupla.Altura}"); */
















/* 
// Trabalhando com dicionários

Dictionary<string, string> estadosBR = new Dictionary<string, string>();

estadosBR.Add("SP", "São Paulo");
estadosBR.Add("MG", "Minas Gerais");
estadosBR.Add("RJ", "Rio de Janeiro");
estadosBR.Add("PR", "Paraná");

foreach(var item in estadosBR)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
    //Console.WriteLine(item);
}
// alterar o valor de uma chave
estadosBR["SP"] = "São Paulo, com valor alterado";
foreach(var item in estadosBR)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


//Pra verificar a existência de uma chave
string chave = "SP";
Console.WriteLine($"Verificando/Pesquisando a existência da chave {chave}");

if(estadosBR.ContainsKey(chave))
{
    Console.WriteLine($"Chave existente: {chave}");
}
else
{
    Console.WriteLine($"Chave não encontrada: {chave}");
}

 */





//Trabalhando com filas
/* 
Queue<int> fila = new Queue<int>();

fila.Enqueue(11);
fila.Enqueue(22);
fila.Enqueue(33);
fila.Enqueue(44);

foreach(int item in fila)
{
    Console.WriteLine($"Item - {item}");
}


//removendo item de uma fila, OBS.: por padrão, só se remove o primeiro a entrar (FIFO)
// fila.Dequeue();

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach(int item in fila)
{
    Console.WriteLine($"Item - {item}");
}
 */

// Trabalhando com Pilhas, Pilha é o contrário de Filas, Filas são FIFO, Pilhas são LIFO
/* 
Stack<int> stack01 = new Stack<int>();

stack01.Push(11);
stack01.Push(22);
stack01.Push(33);
stack01.Push(44);

foreach(int itemstack in stack01)
{
    Console.WriteLine(itemstack);
}

//Remover elemento da pilha
//stack01.Pop(); //remove sempre o ultimo elemento

Console.WriteLine($"Removendo o elemento {stack01.Pop()}");
stack01.Push(200);

foreach(int itemstack in stack01)
{
    Console.WriteLine(itemstack);
}
 */











/* try{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}catch(FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado, ocorreu um erro na leitura do arquivo. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretório não encontrado, ocorreu um erro, caminho da pasta não encontrada. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

 */







/* Pessoa p1 = new Pessoa(nome: "Arthur", sobrenome: "Duarte");

Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");


Curso cursoDeInglês = new Curso();
cursoDeInglês.Nome = "Inglês";
cursoDeInglês.Alunos = new List<Pessoa>();


cursoDeInglês.AdicionarAluno(p1);
cursoDeInglês.AdicionarAluno(p2);
cursoDeInglês.ListarAlunos();
 */















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


