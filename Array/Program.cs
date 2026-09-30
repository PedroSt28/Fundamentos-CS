
//Array (ou um vetor) uma estrutura que armazena
//colecao de tamanho de elementos do mesmo tipo

//criando um arrey e atribuindo um valor diretamente
int[] numero = { 10, 20, 30, 40 , 50 };

// contagem da lista começa apartir do 0


Console.WriteLine(numero[2]);// buscamos um valor atravez da posição

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine(numero[i]);
}

//Crie um programa que receba um arrey de inteiros de 5 posições 
//em seguida calcule e exiba a soma de todos os elementos

int[] listaNumeros = new int[5]; //reservar 5 espaços 
int soma = 0;

for (int i = 0;i < numero.Length;i++)
{
    Console.WriteLine("digite um numero para a posição:" + i);
    listaNumeros[i] = int.Parse(Console.ReadLine());
    soma += listaNumeros[i];
}

Console.WriteLine("a soma dos elementos do array é:" + soma);