using System.Security.Cryptography;

// JOGO DE ADVINHAÇÃO


Console.WriteLine("------------------------------");
Console.WriteLine("JOGO DE ADVINHAÇÃO");
Console.WriteLine("------------------------------");

// 1- Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
Console.WriteLine();
Console.Write("Digite um número: ");
int numdig = Convert.ToInt32(Console.ReadLine());

int numaleatorio = RandomNumberGenerator.GetInt32(1, 21);

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

Console.ReadLine();
