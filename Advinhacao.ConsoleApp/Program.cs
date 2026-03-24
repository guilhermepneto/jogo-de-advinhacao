using System.Security.Cryptography;

// JOGO DE ADVINHAÇÃO

bool continuar = true;

while (continuar == true)
{
    Console.Clear();
    Console.WriteLine("------------------------------");
    Console.WriteLine("JOGO DE ADVINHAÇÃO");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Selecione o nível de dificuldade desejado:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("1 - FÁCIL (10 Tentativas)");
    Console.WriteLine("2 - MÉDIO (5 Tentativas)");
    Console.WriteLine("3 - DIFÍCIL (3 Tentativas)");
    Console.WriteLine("------------------------------");

    Console.Write("Digite sua escolha: ");
    string nivel = Console.ReadLine();

    int numaleatorio;
    int tentativasMax;

    switch (nivel)
    {
        case "1":
            numaleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativasMax = 10;
            break;

        case "2":
            numaleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativasMax = 5;
            break;

        case "3":
            numaleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativasMax = 3;
            break;

        default:
            Console.WriteLine("------------------------------");
            Console.WriteLine("Inválido, por favor selecione uma dificuldade entre 1 e 3!");
            Console.Write("Pressione ENTER para prosseguir.");
            Console.ReadLine();
            continue;
    }

    int[] numDigitados = new int[tentativasMax];
    int contadorNumDig = 0;


    for (int tentativaAtual = 1; tentativaAtual <= tentativasMax; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("------------------------------");
        Console.WriteLine("JOGO DE ADVINHAÇÃO");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativasMax}");
        Console.WriteLine("------------------------------");

        Console.Write("Digite um número: ");
        int numdig = Convert.ToInt32(Console.ReadLine());

        bool numrepetido = false;

        for (int indiceAtual = 0; indiceAtual < numDigitados.Length; indiceAtual++)
        {
            if (numDigitados[indiceAtual] == numdig)
            {
                numrepetido = true;
                break;
            }
        }

        if (numrepetido == true)
        {
            Console.WriteLine("Esse número já foi usado, tente novamente");
            Console.Write("Pressione ENTER para prosseguir");
            Console.ReadLine();

            tentativaAtual--;
            continue;
        }
        if (contadorNumDig < numDigitados.Length)
        {
            numDigitados[contadorNumDig] = numdig;
            contadorNumDig++;
        }
        else
        {
            numDigitados = new int[tentativasMax];
            contadorNumDig = 0;

            numDigitados[contadorNumDig] = numdig;
            contadorNumDig++;
        }


        if (numdig == numaleatorio)
        {
            Console.WriteLine("Muito bem. Você acertou o número secreto, que era: " + numaleatorio);
            break;
        }
        else if (numdig > numaleatorio)
        {
            Console.WriteLine("O número que você digitou é maior que o número secreto");
        }
        else
        {
            Console.WriteLine("O número que você digitou é menor que o número secreto");
        }

        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
    }

    Console.Write("Pressione S para continuar ou N para sair: ");
    string opcaocont = Console.ReadLine();

    if (opcaocont != "S" && opcaocont != "s")
    {
        continuar = false;
    }

    Console.ReadLine();

}

