//// ----------------------Exercicio de repetição 1 --------------------

//int numero = 1; 

//while(numero <= 10)
//{
//    Console.WriteLine(numero);
//    numero++;
//}

////----------------------Exercicio 2 -----------------------------------

//string senha = "123";
//Console.WriteLine("digite a senha correta");
//string confirmacao = Console.ReadLine();
// while(senha != confirmacao)
//{
//    Console.WriteLine("senha incorreta, Digite novamente");
//    confirmacao = Console.ReadLine();

//}
//Console.WriteLine("senha correta");

////------------------------ Exercicio 3--------------------------

//string resposta = "";

//do
//{
//    Console.WriteLine("Executando o processo");
//    Console.WriteLine("Deseja executar nomvamente?");
//    resposta = Console.ReadLine();

//} while (resposta == "s" || resposta == "S");

//Console.WriteLine("Proceso encerrado");

////--------------exercicio 4 ------------

//int numeros = 0;
//int soma = 0;

//do
//{
//    Console.WriteLine("Digite algum número inteiro:");
//    numeros = int.Parse(Console.ReadLine());

//    soma += numeros;

//} while (numeros != 0);

//Console.WriteLine("A soma dos números digitados é: " + soma);

////------------------------ Exercicio 5 ----------------
//int tabuada = 0;
//int multiplicador = 1;
//int resposta = 0;

//Console.WriteLine("me fale a sua tabuada");
//tabuada = int.Parse(Console.ReadLine());

//do
//{

//    resposta = tabuada * multiplicador;
//    Console.WriteLine(tabuada + " X " + multiplicador + " = " + resposta);

//    multiplicador++;

//} while (multiplicador <= 10);


////---------------exercicio 6 ------------------

//int soma = 0;

//for (int i = 1; i <= 100; i++)
//{
//    soma += i;
//}
//;

////------------------Exercicio 7 -----------

//string senha = "";

//do
//{
//    Console.WriteLine("Digite sua senha");
//    senha = Console.ReadLine();

//    if (senha.Length < 8)
//    {
//        Console.WriteLine("Senha muito curta. Digite a senha com no mínimo 8 caracteres");
//    }

//} while (senha.Length < 8);

//Console.WriteLine("Cadastro foi um sucesso");


////Exercicio 8 

//Console.WriteLine("digite um numero");

//int fatorial = 1;
//int numero = int.Parce(Console.ReadLine());
//for (int i = 1; i < numero; i++)
//{
//    fatorial *= i;
//}

//Console.WriteLine(fatorial);

////exercico 10

//int opcoes = 0;
//int num1;
//int num2;

//Console.WriteLine("======Calculadora======");
//Console.WriteLine("1 - soma");
//Console.WriteLine("2 - subtração");
//Console.WriteLine("3 - Multiplicção");
//Console.WriteLine("4 - Divisão");
//Console.WriteLine("5 - sair");

//do
//{
//    Console.WriteLine("selecione a pção desejada");
//    opcoes = int.Parse(Console.ReadLine());

//    if (opcoes == 5)
//    {
//        break;
//    }


//    Console.WriteLine("digite o primeiro numero");
//    num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("digite o segundo numero");
//    num2 = int.Parse(Console.ReadLine());



//    switch (opcoes)
//    {
//        case 1:
//            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//            break;

//        case 2:
//            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//            break;

//        case 3:
//            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//            break;

//        case 4:
//            if (num2 == 0)
//            {
//                Console.WriteLine("nao se pode dividir por zero");
//            }
//            else
//            {
//                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
//            }
//            break;
//    }

//} while (opcoes != 5);

//Console.WriteLine("calculadora fechada");