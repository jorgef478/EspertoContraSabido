Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("~~~~~~ Pica Pau em: Esperto contra Sabido ~~~~~~");
Console.WriteLine();
Console.WriteLine("Em um determinado dia na floresta, Pica Pau e Raposinha discutiam para saber como deveriam dividir sua comida...");
Console.WriteLine("Até que Raposinha teve uma ideia de como fazer e decidiu começar a divisão da sua maneira.");
Console.WriteLine("Para ajuda-los, você deve escrever os alimentos que serão distribuídos.");
Console.Write("Quantos alimentos serão distribuídos? ");
int alimento = Convert.ToInt32(Console.ReadLine());

if (alimento <= 0) return;
Console.WriteLine();


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
Console.WriteLine($"Pica-pau recebeu {picaPau} alimentos.");
Console.WriteLine($"Raposinha recebeu {raposinha} alimentos.");
Console.ResetColor();