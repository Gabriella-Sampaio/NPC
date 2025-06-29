using System.Text;
Console.OutputEncoding = Encoding.UTF8;
int acaoFin = 0;

string nomeNpc = UI.SolicitaNomeNpc();
UI.MensagemSaudacao(nomeNpc); // Criar menu
UI.Menu(nomeNpc);
NPC jogador = new NPC(nomeNpc, acaoFin);

UI.ResultadoFinal(jogador.Nome, jogador.Acoes);
