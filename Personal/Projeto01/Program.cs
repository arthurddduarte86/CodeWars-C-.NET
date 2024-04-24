/* using System.Diagnostics.Contracts;
using Projeto01.Models; */

//Ou o jeito abaixo que não é muito recomendado devido ao tamanho.
// Projeto01.Models.Pessoa p = new Projeto01.Models.Pessoa();
//


/* Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Arthur";
pessoa1.Idade = 38;
pessoa1.Apresentar(); */







/* //Tipos de dados
string apresentacao = "Olá, seja bem vindo!";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine($"Valor de quantidade, {quantidade}");
Console.WriteLine($"Valor de altura, {altura.ToString("0.000")}");
Console.WriteLine("Valor de preço, " + preco);
Console.WriteLine("Condição booleana: " + condicao); */


/* DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); */


/* int a = 30;
int b= 110;
int c=a+b;
Console.WriteLine("" + c);
c+=5;
Console.WriteLine("" + c);
c-=5;
Console.WriteLine("" + c);
c*=5;
Console.WriteLine("" + c);
c/=5;
Console.WriteLine("" + c); */



/* // Casting
int a = Convert.ToInt32("5");
int b = int.Parse("55");
Console.WriteLine(a);
Console.WriteLine(b);

int inteiro = 3;
string aa = inteiro.ToString();
Console.WriteLine(aa);
Console.WriteLine(aa.GetType());


//Casting implicito entre tipos maiores e menores 
int ca=43;
double dc=ca;
Console.WriteLine(dc); */

// Maneira segura de conversão usando TRYPARSE
/* string a = "22-";
//int b = Convert.ToInt32(a); //resulta em erro
int b=0;
int.TryParse(a, out b);
// pode ser desta forma também, sem precisar declarar a variavel antes
int.TryParse(a, out int b); // pode ser desta forma também */


//Condicional IF-ELSE
/* int quantidadeEstoque = 100;
int quantidadeCompra = 4;
bool statusVenda = (quantidadeEstoque >= quantidadeCompra);

Console.WriteLine($"Estoque= {quantidadeEstoque} ");
Console.WriteLine($"Compra = {quantidadeCompra}");
Console.WriteLine($"É possivel a venda? {statusVenda}");

if(statusVenda){
    Console.WriteLine("Venda realizada!");
}
else{
    Console.WriteLine("Não há estoque suficiente...");
}
 */




//Nested IF
/* 
int quantidadeEstoque = 100;
int quantidadeCompra = 4;
bool statusVenda = quantidadeCompra > 0 && (quantidadeEstoque >= quantidadeCompra);

Console.WriteLine($"Estoque= {quantidadeEstoque} ");
Console.WriteLine($"Compra = {quantidadeCompra}");
Console.WriteLine($"É possivel a venda? {statusVenda}");

if (quantidadeCompra == 0){
    Console.WriteLine("Venda inválida pois =0 ");
}
else if(statusVenda){
    Console.WriteLine("Venda realizada!");
}
else{
    Console.WriteLine("Não há estoque suficiente...");
}
 */




//Condicional SWITCH CASE
// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

/* if(
    letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u"
){
    Console.WriteLine("É uma vogal.");
}else{
    Console.WriteLine("Não é uma vogal.");
} */

/* switch(letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal!");
        break;
    case "":
        Console.WriteLine("não é nada!");
        break;
     case " ":
        Console.WriteLine("é um espaço!");
        break;
    default:
        Console.WriteLine("Não é uma vogal!");
        break;
} */



/* 
Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(10, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
 */








// Estruturas de repetição

//int numero = 5;
//Console.WriteLine($"{numero}*1= {numero*1}");

/* for(int contador=0; contador<=10; contador++){
    Console.WriteLine($"{numero}*{contador}= {numero*contador}");

} */

/* int numero =5;
int contador =0;
while (contador<=10){
    // Console.WriteLine($"{contador}");
    Console.WriteLine($"{contador+1}º execução ->{numero}*{contador}= {numero*contador}");
    contador++;
} */


/* int soma=0, numero=0;

do {
    Console.WriteLine("Digite um numero: (0 -> parar)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma+=numero;
    Console.WriteLine($"Soma total dos numeros é {soma}");
}while(numero!=0);

 */



/* string opcao;
bool exibirMenu=true;

while(exibirMenu){
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente: ");
    Console.WriteLine("2 - Buscar cliente: ");
    Console.WriteLine("3 - Apagar cliente: ");
    Console.WriteLine("4 - Encerrar: ");

    opcao = Console.ReadLine();

    switch(opcao){
        case "1": Console.WriteLine("Cadastro de cliente: ");
            break;
        case "2": Console.WriteLine("Busca de cliente: ");
            break;
        case "3": Console.WriteLine("Apagar cliente: ");
            break;
        case "4": Console.WriteLine("Encerrar ");
            exibirMenu=false;
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }


} */




int[] meuarray = {10, 20, 30, 40};
Console.WriteLine($"{meuarray[0]}");












