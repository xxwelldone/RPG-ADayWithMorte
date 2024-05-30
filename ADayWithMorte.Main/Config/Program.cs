using ADayWithMorte.Shared.Sistema.Menu;
using ADayWithMorte.Shared.Sistema;
using ADayWithMorte.Shared.Sound;
using System.Text;
using ADayWithMorte.Shared.Sistema.Timer;
using ADayWithMorte.Shared.Sistema.LuckSistem;
using ADayWithMorte.Core.Service.Sistema.TextChoice;

namespace ADayWithMorte.Main.Config
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //configs do jogo
            Console.OutputEncoding = Encoding.UTF8;
            GameTimer gameTimer = new GameTimer();
            TextBoxFormater text = new TextBoxFormater();

            DiceSistem dice = new DiceSistem();
            MenuInicial menu = new MenuInicial();
            Inventario inventario = new Inventario();
            
            gameTimer.Start();

            menu.DisplayMenu(true);  
            inventario.DisplayMenu(false);

            text.PrintSkullBox("Morte: (rindo) \"Sim, sou Morte. E antes que você pergunte, não, você não está sonhando. Achei que esse seria um lugar interessante para te abordar. Afinal, quem não precisa de uma boa conversa quando acorda, não é?\"\n Você tenta processar a situação absurda enquanto Morte continua. \n Morte: Tenho uma proposta inusitada para você. Você parece ser uma pessoa especial. Que tal ser meu assistente por um dia? É uma experiência única, prometo.\n Conforme você fornece as informações, Morte acena com a cabeça, como se as peças do quebra-cabeça estivessem se encaixando. \"Interessante,\" ela murmura, \"esses detalhes são mais importantes do que você imagina.\"");

            string teste = "Opção 1: Tenho medo de perder as pessoas que amo. (Moral) \n Opção 2:Tenho medo do desconhecido (Harmônico)";

            text.OptionChoice(teste);
            dice.throwDice();
        }
    }
}
