bool inimigoProximo, ferido = true, eliminado = false;
int transi = 0;
Random gerador = new Random();

string nomeNpc = UI.SolicitaNomeNpc();
UI.MensagemSaudacao(nomeNpc);

while (!eliminado) //PROCURANDO
{
    transi++;
    int nmAlPr = gerador.Next(1, 2);

    Console.Write($"{transi}ª ação, {nomeNpc} está procurando");
    UI.Aguardar();

    if (nmAlPr == 1) // volta pro atacando
    {
        ferido = false;
        inimigoProximo = true;
        eliminado = false;
        Console.WriteLine($"Os monstros estão por perto e {nomeNpc} vai atacar"); Thread.Sleep(600);
    }

    else // continua procurando
    {
        inimigoProximo = false;
        Console.WriteLine($"vai continuar procurando"); Thread.Sleep(600);
    }


    while (!eliminado && !ferido && inimigoProximo) //ATACANDO
    {
        transi++;
        // Random gerador = new Random();
        int nmAlAt = gerador.Next(1, 5);
        int nmInimigo = gerador.Next(1, 4); //nm gerador inimigo

        Console.WriteLine($"{transi}ª ação - {nomeNpc} ataca Randall");
        UI.InimigoRandall();

        //COLOCAR MONSTROS DIFERENTES

        UI.Aguardar();

        if (nmAlAt == 1) // continua
        {
            ferido = false;
            inimigoProximo = true;
            Console.WriteLine($"vai continuar atacando"); Thread.Sleep(600);
        }

        else if (nmAlAt == 2) // fugindo
        {
            ferido = true;
            Console.WriteLine($"vai fugir"); Thread.Sleep(600);

        }

        else if (nmAlAt == 3) //volta pro procurando
        {
            ferido = true;
            inimigoProximo = false;
            Console.WriteLine($"desiste e volta a procurar"); Thread.Sleep(600);
        }

        else //morto
        {
            eliminado = true;
            // Console.WriteLine($"Morreu atacando");
        }

    }

    while (!eliminado && ferido && inimigoProximo) //FUGINDO
    {
        transi++;
        Console.Write($"{transi}ª ação, {nomeNpc} está fugindo");
        UI.Aguardar();

        int nmAlFg = gerador.Next(1, 5);
        if (nmAlFg == 1 || nmAlFg == 2) //inimigo desiste / volta pro procurando
        {
            inimigoProximo = false;
            Console.WriteLine($"o inimigo desiste e {nomeNpc} vai procurar"); Thread.Sleep(600);
        }

        else if (nmAlFg == 3) // se cura / 
        {
            ferido = false;
            inimigoProximo = true;
            Console.WriteLine($"{nomeNpc} se cura e volta a procurar"); Thread.Sleep(600);
        }

        else
        {
            eliminado = true; // morre
            // Console.WriteLine($"morreu fugindo");
        }
    }
}

transi++;
Console.WriteLine($"\n{transi}ª ação, {nomeNpc} MORREU");
