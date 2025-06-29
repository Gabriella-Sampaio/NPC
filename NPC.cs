using System.Security.Cryptography.X509Certificates;

public class NPC
{
    public string Nome { get; private set; }
    public int Acoes { get; set; }
    public NPC(string nomeNPC, int acao)
    {
        Nome = nomeNPC;
        Acoes = acao;
        bool inimigoProximo, ferido = true, eliminado = false;
        Random gerador = new Random();

        UI.IntroducaoAHistoria(nomeNPC);

        while (!eliminado) //PROCURANDO
        {
            acao++;
            int nmAlPr = gerador.Next(1, 2);

            Console.Write($"{acao}ª ação - {nomeNPC} está procurando");
            UI.Aguardar();

            if (nmAlPr == 1) // volta pro atacando
            {
                ferido = false;
                inimigoProximo = true;
                eliminado = false;
                Console.WriteLine($"Os monstros estão por perto e {nomeNPC} vai atacar"); Thread.Sleep(600);
            }

            else // continua procurando
            {
                inimigoProximo = false;
                Console.WriteLine($"{nomeNPC} vai continuar procurando"); Thread.Sleep(600);
            }


            while (!eliminado && !ferido && inimigoProximo) //ATACANDO
            {
                acao++;
                // Random gerador = new Random();

                int nmAlAt = gerador.Next(1, 5);
                int nmInimigo = gerador.Next(1, 4); //nm gerador inimigo

                Console.Write($"{acao}ª ação - {nomeNPC} ataca");

                if (nmInimigo == 1)
                {
                    UI.InimigoShrekWazowski("a coisa bizarra chamada ShrekWazowski");
                }

                else if (nmInimigo == 2)
                {
                    UI.InimigoRandall("o temido Randall");
                }

                else
                {
                    UI.InimigoWaternoose("seu inimigo Waternoose");
                }

                UI.Aguardar();

                if (nmAlAt == 1) // continua
                {
                    ferido = false;
                    inimigoProximo = true;
                    Console.WriteLine($"{nomeNPC} vai continuar atacando"); Thread.Sleep(600);
                }

                else if (nmAlAt == 2) // fugindo
                {
                    ferido = true;
                    Console.WriteLine($"{nomeNPC} vai fugir"); Thread.Sleep(600);

                }

                else if (nmAlAt == 3) //volta pro procurando
                {
                    ferido = true;
                    inimigoProximo = false;
                    Console.WriteLine($"{nomeNPC} desiste e volta a procurar"); Thread.Sleep(600);
                }

                else //morto
                {
                    eliminado = true;
                    // Console.WriteLine($"Morreu atacando");
                }

            }

            while (!eliminado && ferido && inimigoProximo) //FUGINDO
            {
                acao++;
                Console.Write($"{acao}ª ação - {nomeNPC} está fugindo");
                UI.Aguardar();

                int nmAlFg = gerador.Next(1, 5);
                if (nmAlFg == 1 || nmAlFg == 2) //inimigo desiste / volta pro procurando
                {
                    inimigoProximo = false;
                    Console.WriteLine($"o inimigo desiste e {nomeNPC} vai procurar"); Thread.Sleep(600);
                }

                else if (nmAlFg == 3) // se cura / 
                {
                    ferido = false;
                    inimigoProximo = true;
                    Console.WriteLine($"{nomeNPC} se cura e volta a procurar outro monstro"); Thread.Sleep(600);
                }

                else
                {
                    eliminado = true; // morreu
                                      // Console.WriteLine($"morreu fugindo");
                }
            }
        }
        acao++;
        Console.WriteLine($"\n{acao}ª ação, {nomeNPC} MORREU");
        Acoes = acao;
        UI.ConfirmaContinuacao("Digite qualquer tecla para continuar");
        Console.ReadKey();
    }
}