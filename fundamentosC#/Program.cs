// comentário
/*esse é o comentario
sobre o dudu guloso*/
/*
// Mostrar texto na tela 
Console.WriteLine("Olá, Dudu guloso"); //toda instrução DEVE terminar com ;


// Guardar informações 
// 1. variaveis (caixinhas onde guardamos informações)

//TIPO NOME-DA-VARIAVEL = VALOR;
int idade = 17; //so preciso declarar a classe de uma variavel uma só vez ou eja se eu quiser chamr a variavel nao preciso chamar mais o 'int'
string nome = "Pedroca";

Console.WriteLine(nome + " quase " + idade + " anos");

//int - integer (numeros inteiros)
//double/float - numeros quebrados
//string - Textos em geral - ""

//----------------------------------------------------------------------------------------------------------------------------------//

//constantes - valor imutavel
const double pi = 3.14159;

Console.WriteLine(pi);

var nom = "Pedro"; // usando var o C# ja entende por si proprio qual tipo de texto é esse (nao é muito usado mas é bom saber que existe)

//char InicialDoNome = 'P'; // O char serve somente para 1 caractere ou seja uma so tecla


Console.WriteLine("Digite seu nome: ");
string NomeUsuario = Console.ReadLine();  // read line serve para ler o que vai ser escrito 

Console.WriteLine("qual é a sua idade");
int idadeUsuario = int.Parse(Console.ReadLine());

Console.WriteLine("Ola, " + NomeUsuario + " tudo bem? voce tem   " + idadeUsuario + " anos");

Console.WriteLine("-------------------interpolação----------------------"); // serve para mesclas as variaveis dentro da string para nao ter que ficar abrindo e fechando aspas so colocando a variavel de uma vez

Console.WriteLine($"Olá, {NomeUsuario}! voc tem {idadeUsuario}!");



//-------------------------------------- OPERAÇOES MATEMATICAS ---------------------------------------//

int soma = 10 + 5;
int subtração = 10 - 5;
int multiplicação = 10 * 5;
int divisao = 10 / 5;

Console.WriteLine(soma);
Console.WriteLine(subtração);
Console.WriteLine(multiplicação);
Console.WriteLine(divisao);





//condicionais(if/else)

//------------------------Operador ternario (if else) em maneira resumida-----------------

int idadeAluno = 25;
string mensagem;

if (idadeAluno > 18)
{
    mensagem = "maior de idade";
}
else
{
    mensagem = "menor de idade";
}

mensagem = (idadeAluno > 18) ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);



// --------------------------------------Estruturas de Repetição------------------------------ Estruturas que se repetem

// while  (enquanto)
// enquanto (condição for verdade) { faz algo }
//peço uma senha, em quanto a senha for errada, eu pergunto dnv
Console.WriteLine("digite senha");
string senha = Console.ReadLine();

while (senha != "pedro") ; //aqui fala qu se a senha for diferente de "pedro"(se estiver errado) vai acontecer oque esta entre a chave ou seja a senha esta errada
{
    Console.WriteLine("Senha incorreta"); // manda a mensagem que a senha deu incorreta

    Console.WriteLine("Digite sua senha"); // pede mais uma vez para digitar a senha 
    senha = Console.ReadLine(); //declara o valor de senha novamente para comparar com a senha correta "pedro"
}

 

// for -> para 
/*
 
 for ( inicialização; condição ; incremento
 {
    codigo que se repete
 }

*/

// Ultilizando for imprima o numero 1 ao numero 5.
/*
for (int i = 1; i<=5 ; i++)
{
    Console.WriteLine(i);
}

// ultilizando for façã uma contagem regressiva começando em 10


for(int a = 10; a >= 1; a--)
{
    Console.WriteLine(a);
}
*/
// ultilizando for exiba os numeros de 0 ate 20 imprimindo de 2 em 2

for ( int  i = 0; i <=20; i+=2) //mesma coisa de i = i +2
{
    Console.WriteLine(i);
}