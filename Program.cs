Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("~~~~~~ Pica Pau em: Esperto contra Sabido ~~~~~~");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Em um determinado dia na floresta, ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Pica Pau");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" e ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Raposinha");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" discutiam para saber como deveriam dividir sua comida...");
Console.WriteLine("Até que Raposinha teve uma ideia de como fazer e decidiu começar a divisão da sua maneira.");
Console.WriteLine("Para ajuda-los, você deve escrever quanto de comida será distribuído a cada um.");
Console.WriteLine();
Console.Write("Quantos kg de alimento serão repartidos? ");
Console.ForegroundColor = ConsoleColor.DarkRed;

int alimento = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkBlue;

if (alimento <= 0)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine();
Console.WriteLine("O NÚMERO DIGITADO É INVÁLIDO. TENTE NOVAMENTE!");
Console.ResetColor(); 
return;
}

int restantes = alimento;
int picaPau = 0, raposinha = 0;
int paraVoce = 0, paraMim = 0;

while (restantes > 0)
{
   
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    paraVoce++;
    picaPau += 1;
    restantes -= 1;

    Console.Write($"{picaPau} para você. ");
 
    paraMim = 0;
    while (restantes > 0 && paraMim < paraVoce)
    {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
        paraMim++;
        raposinha += 1;
        restantes -= 1;

        Console.Write($"{paraMim}");

        if (restantes > 0 && paraMim < paraVoce )
        {
            Console.Write(",");

        }

        Console.Write(" ");
    }

    if (paraMim > 0 || paraMim < paraVoce)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        paraMim++;
        raposinha += 1;
        restantes -= 1;
    
        Console.WriteLine($"{paraMim} para mim.");
        
    }

}

if (paraMim == 0)
{
Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine();
Console.WriteLine($"Pica-pau recebeu {picaPau} kilos de comida.");
Console.WriteLine($"Raposinha recebeu {raposinha} kilos de comida.");
Console.ResetColor();
