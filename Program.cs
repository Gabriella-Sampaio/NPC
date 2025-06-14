Console.Clear();

bool inimigoProximo = false, ferido = true, eliminado = false;
int iP = 0, iA = 0;
Random gerador = new Random();

Console.WriteLine("NPC");
Console.Write("Digite o nome do NPC: ");
string nomeNpc = Console.ReadLine()!;

Console.WriteLine($"olá {nomeNpc}");

while(!eliminado) //PROCURANDO
{
    iP++;

    int nmAlPr = gerador.Next(1, 2);

    Console.Write($"Teste - ta procurando... ");

    if(nmAlPr == 1) // volta pro atacando
    {
        ferido = false;
        inimigoProximo = true;
        eliminado = false;
        Console.WriteLine($"vai atacar");
    }

    else // continua procurando
    {
        inimigoProximo = false;
        Console.WriteLine($"vai continuar procurando");
    }


    while(!eliminado && !ferido && inimigoProximo) //ATACANDO
    {
        
        iA++;
        // Random gerador = new Random();
        int nmAlAt = gerador.Next(1, 5);
        
        Console.Write($"Teste - ta atacando... ");
        
        if(nmAlAt == 1) // continua
        {
            ferido = false;
            inimigoProximo = true;
            Console.WriteLine($"vai continuar atacando");
        }

        else if(nmAlAt == 2) // fugindo
        {
            ferido = true;
            Console.WriteLine($"vai fugir");

        }

        else if(nmAlAt == 3) //volta pro procurando
        {
            ferido = true;
            inimigoProximo = false;
            Console.WriteLine($"vai procurar");
        }

        else //morto
        {
            eliminado = true;
            Console.WriteLine($"Morreu atacando");
        }

    }

    while(!eliminado && ferido && inimigoProximo) //FUGINDO
    {
        Console.Write($"Teste - ta fugindo... ");

        int nmAlFg = gerador.Next(1, 5);
        if (nmAlFg == 1 || nmAlFg == 2) //inimigo desiste / volta pro procurando
        {
            inimigoProximo = false;
            Console.WriteLine($"inimigo desiste e vai procurar");
        }

        else if (nmAlFg == 3) // se cura / 
        {
            ferido = false;
            inimigoProximo = true;
            Console.WriteLine($"se cura e vai procurar");
        }

        else
        {
            eliminado = true; // morre
            Console.WriteLine($"morreu fugindo");
        }
    }
}

Console.WriteLine($"MORREU");
