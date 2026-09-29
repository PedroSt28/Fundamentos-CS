Console.WriteLine("selecione a opção de deseja: \n 1- Novo salario \n 2- Férias \n 3- Décimo terceiro\n 4- Sair");
int opcao  = int.Parse(Console.ReadLine());

double salario ;
int meses;


if (opcao == 1)
{
    Console.WriteLine("voce escolheu a opçao de novo salario");
    Console.WriteLine("quanto que voce ganha hoje?");
    salario = double.Parse(Console.ReadLine());

    double novoSalario;

    if (salario <= 349)
    {
        novoSalario = salario + salario * 0.15;
        Console.WriteLine($"Seu novo salario é {novoSalario}");

    }
    else if (salario <= 599)
    {
        novoSalario = salario + salario * 0.1;
        Console.WriteLine(novoSalario);
    }
    else
    {
        novoSalario = salario + salario * 0.05;
        Console.WriteLine(novoSalario);
    }

}
else if (opcao == 2)
{
    Console.WriteLine("suas ferias");
    Console.WriteLine("quanto que voce ganha hoje?");
    salario = double.Parse(Console.ReadLine());

    double ferias = salario + salario * 0.5;

    Console.WriteLine($"voce ganha urante as ferias: {ferias}");
}
else if (opcao == 3)
{
    Console.WriteLine("seu decimo terceiro");
    Console.WriteLine("quanto que voce ganha hoje?");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("quantos meses voce trabalha no ano?");
    meses = int.Parse(Console.ReadLine());

    if( meses <= 0 || meses > 12)
    {
        Console.WriteLine("numero invalido dgite novamente");
    }
    else
    {

        double decimo = (salario * meses) / 12;
        Console.WriteLine($"seu decimo terceiro é {decimo}");
    }

}
else
{
    Console.Write("Adeus");
}