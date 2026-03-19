using System.Security.Cryptography;

// JOGO DE ADVINHAÇÃO


Console.WriteLine("------------------------------");
Console.WriteLine("JOGO DE ADVINHAÇÃO");
Console.WriteLine("------------------------------");

// 1- Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
Console.WriteLine();
Console.Write("Digite um número: ");
string strnumdig = Console.ReadLine();


int numaleatorio = RandomNumberGenerator.GetInt32(1, 21);

Console.WriteLine("O número aleatório foi: " + numaleatorio);

Console.ReadLine();
