
string nome = "";
string nick = "";
string plataforma = "";
double saldo;
double ano;
string nomeJogo = "";
string plataformaJogo = "";
double precoJogo = 0;
int quantJ = 0;
//string biblioteca = "";



// para colocar dados do cliente


Console.WriteLine("=== Cadastro do cliente I ===");

Console.WriteLine("Determine seu nome:");
nome = Console.ReadLine();
Console.WriteLine("Nickname:");
nick = Console.ReadLine();
Console.WriteLine("Sua plataforma - PS5, PC , XBOX ou SWITCH:");
plataforma = Console.ReadLine();
Console.WriteLine("Cliente desde:");
ano = double.Parse(Console.ReadLine());
Console.WriteLine("Saldo R$");
saldo = double.Parse(Console.ReadLine());



//colocando dados do cliente a mostra
Console.WriteLine("=== Ficha ==");

Console.WriteLine($"Seu nome: {nome}");
Console.WriteLine($"Seu nick: {nick}");
Console.WriteLine($"Sua plataforma: {plataforma}");
Console.WriteLine($"Seu saldo: R${saldo}");
Console.WriteLine($"Seu ano de cadastro: {ano}");






//Vendo se o usuario consegue comprar o jogo 

Console.WriteLine("\n------ Parte de Compra II ------");

Console.WriteLine("\nQual jogo você quer comprar?");
nomeJogo = Console.ReadLine();
Console.WriteLine("Para qual plataforma:");
plataformaJogo = Console.ReadLine();
Console.WriteLine("Qual o preço:");
precoJogo = double.Parse(Console.ReadLine());

if (plataformaJogo != plataforma) //nao permite o usuario comprar se as plataformas forem diferentes
{
    Console.WriteLine("Não é disponivel em sua plataforma");
}
else if (precoJogo > saldo)// se o usuario nao tiver saldo o suficiente
{
    Console.WriteLine("Saldo insuficiente");
}
else
{
    Console.WriteLine($"Você consegue comprar o {nomeJogo}, e o seu novo saldo será de R${saldo - precoJogo} "); //calcula o resto do saldo depois de efetuar a compra
}


//-----------------Parte III --------------
Console.WriteLine("-----------------Parte III--------------");
Console.WriteLine("Quantos Jogos voce tem");
quantJ = int.Parse(Console.ReadLine());



string[] biblioteca = new string[quantJ];

for (int i = 0; i < quantJ; i++)
{
    Console.WriteLine("Me fale o nome desses jogos -- Escreva o nome de um e envia");
    biblioteca[i] = Console.ReadLine();
}
for (int i = 0; i < biblioteca.Length; i++)
{
    Console.WriteLine("Os seus jogos são:" + biblioteca[i]);
}


// -----------------Parte IV--------------
Console.WriteLine("-----------------Parte IV--------------");
string verificarJogo;
Console.WriteLine("Qual jogo você quer verificar?");


verificarJogo = Console.ReadLine();
for (int i = 0; i < biblioteca.Length; i++)
{
    if (biblioteca[i] == verificarJogo)
    {
        Console.WriteLine("Você ja possui o jogo");
        break;
    }
    else if (biblioteca[i] != verificarJogo)
    {

        Console.WriteLine("Voce nao tem o jogo, pode comprar");
        break;
    }
}

// -----------------Parte V--------------
Console.WriteLine("-----------------Parte V--------------");

double valorPago =0 ;
double[] valoresJogos = new double[biblioteca.Length];
double mediaPago;

for (int i = 0; i < biblioteca.Length; i++)
{
    Console.WriteLine($"Quanto voce pagou em: {biblioteca[i]} ");
    valoresJogos[i] = double.Parse(Console.ReadLine());
    valorPago += valoresJogos[i]; 
}



  mediaPago = valorPago/ valoresJogos.Length;
Console.WriteLine($"a media que voce gasta em jogos é {mediaPago}");

if(valorPago >= 500)
{
    Console.WriteLine("voce é um cliente vip");
}
else
{
    Console.WriteLine($"VOCE PRECISA PARA ENTRAR NO VIP DE : {500 - valorPago}");
}

//-------------nivel 6 ---------------
string nomeMaior = "";
double valorMaior = 0 ;


for (int i = 0; i < valoresJogos.Length; i++)
{
    if (valoresJogos[i] > valorMaior)
    {
        valorMaior = valoresJogos[i];
        nomeMaior = biblioteca[i];

    }
}

Console.WriteLine($"seu jogo com maior preço é o {nomeMaior} custando : {valorMaior}");
