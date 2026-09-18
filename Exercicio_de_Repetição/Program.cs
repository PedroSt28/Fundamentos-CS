// ----------------------Exercicio de repetição 1 --------------------

int numero = 1; 

while(numero <= 10)
{
    Console.WriteLine(numero);
    numero++;
}

//----------------------Exercicio 2 -----------------------------------

string senha = "123";
Console.WriteLine("digite a senha correta");
string confirmacao = Console.ReadLine();
 while(senha != confirmacao)
{
    Console.WriteLine("senha incorreta, Digite novamente");
    confirmacao = Console.ReadLine();

}
Console.WriteLine("senha correta");