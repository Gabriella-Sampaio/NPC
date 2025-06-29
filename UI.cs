public class UI
{
    public static string SolicitaNomeNpc()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Antes de começarmos");
        Console.ResetColor();
        Console.Write("Digite o nome do seu NPC: ");
        Thread.Sleep(1000);
        return Console.ReadLine()!;
    }
    public static void MensagemSaudacao(string nmNpc)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"     🦎👹  Bem vindo(a) {nmNpc} 👹🦎");
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("            Simulação NPC             ");
        Console.WriteLine("            Monstros S.A.             ");
        Console.WriteLine("               🤖  🐲  ⚔              "); Thread.Sleep(500);
        Console.ResetColor();
    }
    public static void Menu(string nm)
    {
        int opcao = 0;
        while (opcao != 1)
        {
            Console.Clear();
            MensagemSaudacao(nm);
            Console.Write(@"
        Digite a opção desejada:

Começar    - [1]
Instruções - [2]
Sair       - [3]

Opção: ");
            string opcaoString = Console.ReadLine()!;

            if (!Int32.TryParse(opcaoString, out opcao))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Digite um valor válido");
                Aguardar();
                Console.ResetColor();
            }

            else if (opcao == 2)
            {
                Instrucoes();
            }

            else if (opcao == 3)
            {
                Console.Write("\nTem certeza? [S] ou [N]: ");
                string confirmacao = Console.ReadLine()!.ToUpper();

                if (confirmacao == "S")
                {
                    MensagemFinal();
                    Environment.Exit(0);
                }
            }
        }
    }
    public static void Instrucoes()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Seja muito bem vindo ao nosso simulador de NPC"); Thread.Sleep(1200);
        Console.ResetColor();
        Console.WriteLine("Aqui você simula a batalha do seu NPC"); Thread.Sleep(900);
        Console.WriteLine("contra os monstros mais assustadores"); Thread.Sleep(900);
        Console.WriteLine("do mundo de Monstros S.A.\n"); Thread.Sleep(1200);

        Console.WriteLine("Selecione [1] e em seguida [Enter] para começar"); Thread.Sleep(900);
        Console.WriteLine("Ou [3] para sair\n"); Thread.Sleep(1200);

        Console.WriteLine("Obrigado e boa imulação");
        ConfirmaContinuacao("Digite qualquer tecla para continuar");
    }
    public static void Aguardar()
    {
        Thread.Sleep(400);
        Console.Write(".");
        Thread.Sleep(400);
        Console.Write(".");
        Thread.Sleep(400);
        Console.Write(". ");
        Thread.Sleep(400);
    }
    public static string ConfirmaContinuacao(string mensagem)
    {
        Console.Write($"{mensagem}");
        Aguardar();
        Console.ReadKey();
        return mensagem;
    }
    public static void AguardaAntesDaImagem()
    {
        Aguardar();
        Thread.Sleep(1000);
        Console.Clear();
    }

    public static void ResultadoFinal(string nmNpc, int acao)
    {
        Console.Clear();
        Console.WriteLine("              🐲 Resultado ⚔              "); Thread.Sleep(800);
        Console.WriteLine($"Seu NPC {nmNpc} sobreviveu a {acao} transições antes de morrer");
        MensagemFinal();
    }
    public static void MensagemFinal()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nMuito obrigado por utilizar nosso programa"); Thread.Sleep(800);
        Console.ResetColor();
        ConfirmaContinuacao("Digite qualquer tecla para encerrar");
        Console.ReadKey();
    }
    public static void IntroducaoAHistoria(string nmNPC)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{nmNPC} entrou em seu armário "); Thread.Sleep(800);
        Console.WriteLine("e está no mundo dos monstros");Thread.Sleep(800);
        Console.ResetColor();
    }

    public static string InimigoRandall(string mensagem)
    {
        AguardaAntesDaImagem();
        Console.WriteLine("Inimigo Randall");
        Console.WriteLine(@"````````````````````'Xx.`*+'.+^`````````````````````````````
`````````````````````^X^`+*.,+^`````````````````````````````
`````````````````````'Xx.:*^^^^`````````````````````````````
``````````````````````:$+^*^+++:...'````````````````````````
``````````````````````'Xx*+^^++++++++^^^::,.````````````````
````````````''''```````*$**+^^^^++++++++^^++:'``````````````
`````````.:^++^^^:,```'*$x*+^^^+xxx***x***x*+^'`````````````
````````^x****+^++*+:+xxx*++^^^+xX$XXXXX$XXxXx+,'```````````
```````,XXxxx***xx+*$$x**+^^^^^+x$&%&$X#@Xx.+Xx+*+^:'```````
```````+X*^*$&$XXXXX&X***+^^^^^^*$%&$x*x$$&&&$**+**+^```````
```````:&%&&$%%$$X$XXx***++^^:^^+X&&&&%###%&Xx*^++^++.``````
```````,$#@##%%&$x**xx****++^:,:^+X$&&&&&$Xx**+^+^^$+,``````
``````.$XX%#%%&&$Xxx*xx****+^^^^^^+*xXXxxxxx*+++^^%%+,``````
``````.XXx$&&%&$Xxx**xxx***++^^^+^+******+++^+^^*%@x+.``````
``````.**xX$$$Xx***xxXXxxX**+++++++++++++++^^^^x#@X*^```````
```````++*********xXXXx$Xxxx*****+^++++++++^^^x#%x**````````
```````,*+++*****xxxxxX$Xxxxxx***+++++++^^^+*xXX+x*'````````
````````^*++++++**xxxxXXXXXxx****+++^+++xx^^*X*+x+'`````````
`````````^**++^++++**xxxxxx*++++++*xXxx^+x+^++*x:```````````
``````````:Xxxx**+**+++++**+*xxX$$*x$**x+*++*Xx+````````````
```````````.*$$X$&$$&&X$&&%Xx&&xxXx**xx*+*x$$X**'```````````
`````````````:xXX$$&$&&$&&$$Xx$$$$x**+*x$&&&$x+*,```````````
```````````````,+X$$XX$$$$$XXxx*++++*xXX$$&&X***^```````````
`````````````````',^**x*++++^+^^^:::^*xX$$&&X*+++```````````
``````````````````````'.,,.,,.'````,^++xX$&&x****```````````
``````````````````````````````````,^+++xx$&X+++x*```````````
`````````````````````````````````,^^+***X$$x+^^x+```````````
``````````````````````````,^^:``,:+++*+*x$X*+*+x:```````````
```````````````````'````.^***+'.^^++****xx*+^+xX:```````````
```````````````'^^++^:`'xXXXX,.:+++******++^^:*$,```````````
```````````````:&X&$Xx,'&&$x:.^^+++****+^^::::^x'```````````
```````````````'$%%%&&X^X&$x^:^^++***+++^*+^:^:^````````````
`````````````````.,$%x$&$X**^^^^***+^^^^+X$*^^^^.```````````
```````````````````$&++*xX$x*+^^++::,:^^*X$$*^^:^'``````````
``````````````.::::+*^+*^+******++^::^:+XX$&$x+^^:``````````
`````````````,Xxx**+*XxxxXXXXxxXX$Xx*+++++xxX+x*^^:`````````
`````````````.$&%%&$XX***+^:::,::^+*X$$$Xx**+^^+^^^,````````
````````````,+X&%$+,,^++^::::::,::::+xX$&&&xX$$Xx**+,```````
```````````'x&$+.``.:^^^:,,,:::^^^++X$$&&&^``',^+xx*.```````
`````````````'````.:^^::,,::,:^^+*X$XX&&&^``````````````````");
        return mensagem;
    }
    public static string InimigoShrekWazowski(string mensagem)
    {
        AguardaAntesDaImagem();
        Console.WriteLine("Inimigo ShrekWazowski");
        Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣄⢀⡀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⢰⣿⢻⡾⡇
⠀⠀⠀⠀⠀⢀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣴⡞⠋⠉⠉⠀⣀⡉⠉⠉⠉⠒⠦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣷⡄⠀⠀⢠⣿⢋⣾⣿⠁
⠀⠀⠀⢀⣴⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣴⣟⣫⡤⠤⠴⠶⠟⠛⣿⣉⡙⠛⠒⠀⠀⠀⠙⠳⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⢣⣀⣴⡟⠋⢹⣽⠃⠀
⠀⠀⠀⣾⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⣴⣿⣭⣥⣤⣀⣀⣀⠀⣀⣀⢈⡿⢻⣦⣀⣀⠀⠀⣀⣀⣬⡓⣄⠀⠀⠀⠀⠀⠀⠀⣰⣿⣷⣄⣸⡌⠉⡇⠟⢀⡞⠁⠀⠀
⠀⠀⠀⠈⠙⠛⠿⣿⣿⣦⡀⠀⠀⠀⢀⣾⣿⣿⡛⠛⠿⣿⣿⣿⣿⣿⣿⣿⡟⢿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⡇⣼⠁⣰⠏⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣦⣀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⣧⣼⣿⢿⣷⣾⣿⣿⣿⣿⣷⣶⣌⢦⡀⠀⠀⣠⣿⡿⠿⠛⠉⠉⣿⣿⠞⠁⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⢟⣿⣿⣿⣿⣿⡟⣻⣿⣿⡿⣿⣿⣟⣠⣴⡾⠿⢿⣼⣿⣿⣿⢿⣷⣶⣭⣝⢿⣷⠻⣶⣾⡿⠋⠀⠀⠀⠀⠀⢻⣿⣧⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣽⣾⠛⠋⠛⠿⢿⣿⣿⣿⣿⠿⠿⠛⣻⣭⣤⣤⣄⡀⠈⠛⢿⣶⣿⣿⣿⣤⠟⠈⠙⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣇⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡟⠁⠀⠀⠀⠀⠀⠀⠀⣰⣟⠀⣤⡾⠋⠁⠈⠁⢱⣉⣀⠀⠀⠀⠸⣏⠉⠉⠉⠁⠀⠀⠀⢻⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⡾⡆⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠅⠀⠀⠀⠀⠀⠀⣠⣾⣿⣮⣿⣿⣦⣤⣄⣀⣀⣘⣿⣦⡄⣀⣤⣤⣼⣿⣶⣄⡀⠀⠀⠀⠈⣇⠀⠀⠀⠀⠀⠀⠀⠀⠘⣧⣹⡄⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⡏⠀⠀⠀⢀⣤⣴⣿⠿⠋⠉⠛⠛⠻⠿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠛⠿⣿⣷⣿⣿⣦⣀⠀⠀⢹⡀⠀⠀⢀⣠⣴⠶⠚⠋⣉⣻⡿⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠇⠀⠀⢢⣿⠟⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⣨⡽⠿⠉⠻⣿⡄⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣷⣦⠀⢹⡶⠚⠋⢁⣀⣤⠴⠞⠉⠁⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⡗⠀⠀⠘⠋⢰⣾⣧⣤⣤⣤⣤⣄⣄⣀⣷⡀⠀⠀⠀⠀⠸⠇⣀⣀⣀⣀⡀⠀⠘⣿⡝⢿⣿⡿⠀⢸⣧⠶⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢀⣴⡿⣻⣿⡇⠀⠀⠀⠀⠉⢹⣿⣿⣿⣿⢿⣿⠛⢻⣿⠿⢿⣶⡿⣿⣿⣿⡿⢿⣿⣿⣿⣿⣿⡿⢷⠈⡏⠁⠀⢸⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢀⣴⠞⣫⡾⠛⣿⠃⠀⠀⠀⠀⠀⠀⠙⠻⣿⣿⣿⣿⣤⣼⣇⣀⣴⣿⣁⠉⠀⣿⣇⣤⣧⣸⣿⣿⡿⠁⠀⠀⡇⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⣾⠛⡿⠁⠀⠀⠻⣧⣠⠀⠀⠀⠀⠀⠀⠀⠈⢛⣛⣿⣟⡻⣿⢛⣛⡛⣿⣿⢿⣿⣟⡻⣿⠿⠋⠀⠀⠀⠀⠀⠀⠀⢀⡾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢰⡟⢸⠇⠀⠀⠀⠀⠹⣿⡀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠻⠷⢶⣭⣤⣭⣏⣥⣭⣈⣩⣿⣧⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⢸⠃⡾⠀⠀⠀⠀⠀⠀⠙⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠉⠙⢷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⣿⢀⠇⠀⠀⠀⠀⠀⠀⠀⠹⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣛⣛⡦⠀⠀⠀⠀⠀⠀⣼⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⢸⡇⣼⠀⠀⠀⠀⠀⠀⠀⠀⠀⡹⣿⡿⣶⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠰⠟⠋⠉⠁⠀⠀⠀⠀⣀⡼⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣼⡇⢻⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⡿⠉⢸⡟⢷⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣟⣦⠀⠀⠀⠀⢀⣤⠞⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣿⠇⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⣸⠃⠀⡿⠁⠀⠈⠙⠷⢶⣤⣀⣀⣀⣀⣀⣀⣀⣀⣀⣨⡻⣷⣤⡴⠞⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢸⣿⠀⣿⣝⡆⠀⠀⠀⠀⠀⠀⢠⡟⠀⣼⠃⠀⠀⠀⠀⠀⠀⠀⠉⠉⠛⠛⠛⠛⠛⠛⠛⢿⡷⠛⢻⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢸⣟⢸⠙⣿⡀⠀⠀⠀⠀⠀⠀⣼⡇⢠⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣷⠀⢘⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠘⣿⣿⠀⢿⣷⡀⠀⠀⠀⠀⠀⣿⣇⣾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⡆⢀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠹⣿⣦⠀⠈⠁⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⢿⣾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠘⠿⡿⠀⠀⠀⠀⠀⠀⠀⢸⡿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡞⢁⡞⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣇⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡟⢁⡞⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠟⢠⡞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣤⣴⣶⡴⠶⢤⣤⡶⠿⠋⠙⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠋⠀⡞⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢰⣿⣯⣴⣇⣠⣾⠋⣶⢀⣠⣶⡿⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⡿⠋⠀⠒⠛⠲⢤⣤⣄⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⠉⠉⠙⠛⠛⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠷⠶⣤⣤⣤⣀⣀⡈⠙⡁⢸⡛⢿⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠙⠛⠺⠾⠿⠾⠿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        return mensagem;
    }
    public static string InimigoWaternoose(string mensagem)
    {
        AguardaAntesDaImagem();
        Console.WriteLine("Inimigo Waternoose");
        Console.WriteLine(@"```''```''````'````'`````.::,''```''```''````'````'````'````
```````````````````````'+xx*^:.:,'``````````````````````````
``````````````````````.xxxxx++:+::.`````````````````````````
```'`````'````'``````,xx*+****+::,,,`````````'````'````'````
``````````````````,^X#XXxxx***+^::,:$+'``','````````````````
`````````````````*@@@@#&$$XXx++^^::*@@&XXxx*:```````````````
```````````````:$##@##%%Xx**X%&$$%x:%@@#$&Xxx^'`````````````
`'````'``````:$#%$$&&&$$%%%&&&$Xx*$&%#@@@#$XxXX,``````````'`
```````````,$##%&&%&XX%%#@##%%%&%%%%%&&%##%XX&&X'```````````
``````````:@@@&&%##$X%@@#%%%%%%&%&&$$&&&$XX&#$^'````````````
`'````'```X@@@$%%$$%@@%$XXxxxxxxx*++++*+^^:^%+````````````'`
``````````.$#@%&%%@###%&XXxxxxx********+++++*.``````````````
````````'+*x$&+X##@%&%#%%&$$$XXxxx*xxxxxxXXX:':+^^:`````````
````',:+*$XX%&$&X$#@#%%%%&&&&&$&$$&$$$$$$XX^::^xXx*:'```````
``.+*x*xxXx^*+x$$*$&XxX&$XXXXXX$$&%$XXXXxx,,:.:x$$x*+^:.````
``*x++*xx$$x:,X$XX*+::*XXxx$$$$$&%&&$&&XXX+^'.+xX$XXxx**^'``
``xx^+*+:$&X+.:XX$*:^+Xx++::^^*xX&&$X$$XXX$X^+xxX$XXXXX**^``
``xX+*:`'&#$X*^*$$*+*XX*+,```````^$$^*$$$$$&%$xX$$^X+:$Xx+``
``*&%X:``*X.*XX$$$XxX&X*:````````````...:^^+X$Xx+.`:^'xXx*'`
``,##.```.:``':$XXXX+xx,````````````````````',.```````'*$x``
```$&.`````````X$XX^```````````````````````````````````*#+``
`'`'x'`````'```*&&+````````'````'````'````'````'```````:%.``
````'``````````.#%,````````````````````````````````````.,```
````````````````x%'`````````````````````````````````````````
''````'````'````.+```''```''````'````'````'````''```''````'`");
        return mensagem;
    }
}