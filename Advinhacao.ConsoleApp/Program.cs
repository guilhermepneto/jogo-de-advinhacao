using System.Security.Cryptography;

// JOGO DE ADVINHAÇÃO

int numaleatorio = RandomNumberGenerator.GetInt32(1, 21);
bool continuar = true;

while (continuar == true)
{
    Console.Clear();
    Console.WriteLine("------------------------------");
    Console.WriteLine("JOGO DE ADVINHAÇÃO");
    Console.WriteLine("------------------------------");

    Console.WriteLine();
    Console.Write("Digite um número: ");
    int numdig = Convert.ToInt32(Console.ReadLine());


    if (numdig == numaleatorio)
    {
        Console.WriteLine("Muito bem. Você acertou o número secreto, que era: " + numaleatorio);
    }
    else if (numdig > numaleatorio)
    {
        Console.WriteLine("O número que você digitou é maior que o número secreto");
    }
    else
    {
        Console.WriteLine("O número que você digitou é menor que o número secreto");
    }

    Console.WriteLine();
    Console.Write("Pressione S para continuar ou N para sair: ");
    string opcaocont = Console.ReadLine();

    if (opcaocont != "S" && opcaocont != "s")
    {
        continuar = false;
    }

    Console.ReadLine();

}

