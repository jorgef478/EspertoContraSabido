Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("~~~~~~ Pica Pau em: Esperto contra Sabido ~~~~~~");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Em um determinado dia na floresta, Pica Pau e Raposinha discutiam para saber como deveriam dividir sua comida...");
Console.WriteLine("Até que Raposinha teve uma ideia de como fazer e decidiu começar a divisão da sua maneira.");
Console.WriteLine("Para ajuda-los, você deve escrever quanto de comida será distribuído a cada um.");
Console.Write("Quantos kg de alimento serão repartidos? ");
Console.ForegroundColor = ConsoleColor.DarkRed;

int alimento = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkBlue;

if (alimento <= 0)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("O NÚMERO DIGITADO É INVÁLIDO. TENTE NOVAMENTE!");
Console.ResetColor(); Console.WriteLine();
}

int restantes = alimento;
int picaPau = 0, raposinha = 0;
int paraVoce = 0, paraMim = 0;

while (restantes > 0)
{
    paraVoce++;
    picaPau += 1;
    restantes -= 1;

    Console.Write($"{picaPau} para você. ");

    paraMim = 0;
    while (restantes > 0 && paraMim < paraVoce)
    {
        paraMim++;
        raposinha += 1;
        restantes -= 1;

        Console.Write($"{paraMim}");

        if (restantes > 0 && paraMim < paraVoce)
        {
            Console.Write(",");
        }

        Console.Write(" ");
    }

    if (paraMim > 0)
    {
        Console.WriteLine("para mim.");
    }
}

if (paraMim == 0)
{
Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"Pica-pau recebeu {picaPau} kilos de comida.");
Console.WriteLine($"Raposinha recebeu {raposinha} kilos de comida.");
Console.ResetColor();
