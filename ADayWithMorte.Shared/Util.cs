using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ADayWithMorte
{
    internal class Util
    {
        public static void MakeTitle()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            int width = Console.WindowWidth;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"('-.          
  ( OO ).-.       
  / . --. /       
  | \-.  \        
.-'-'  |  |           
 \| |_.'  |        
  |  .-.  |       
  |  | |  |   
  `--' `--'");
            sb.AppendLine(@" _ .-') _     ('-.                
( (  OO) )   ( OO ).-.            
 \     .'_   / . --. / ,--.   ,--.
 ,`'--..._)  | \-.  \   \  `.'  / 
 |  |  \  '.-'-'  |  |.-')     /  
 |  |   ' | \| |_.'  (OO  \   /   
 |  |   / :  |  .-.  ||   /  /\_  
 |  '--'  /  |  | |  |`-./  /.__) 
 `-------'   `--' `--'  `--'      ");
            sb.AppendLine(@"  (`\ .-') /`       .-') _    ('-. .-. 
   `.( OO ),'      (  OO) )  ( OO )  / 
,--./  .--. ,-.-') /     '._ ,--. ,--. 
|      |  | |  |OO)|'--...__)|  | |  | 
|  |   |  |,|  |  \'--.  .--'|   .|  | 
|  |.'.|  |_)  |(_/   |  |   |       | 
|         |,|  |_.'   |  |   |  .-.  | 
|   ,'.   (_|  |      |  |   |  | |  | 
'--'   '--' `--'      `--'   `--' `--'");
            sb.AppendLine(@" _   .-')                _  .-')   .-') _     ('-.   
( '.( OO )_             ( \( -O ) (  OO) )  _(  OO)  
 ,--.   ,--.).-'),-----. ,------. /     '._(,------. 
 |   `.'   |( OO'  .-.  '|   /`. '|'--...__)|  .---' 
 |         |/   |  | |  ||  /  | |'--.  .--'|  |     
 |  |'.'|  |\_) |  |\|  ||  |_.' |   |  |  (|  '--.  
 |  |   |  |  \ |  | |  ||  .  '.'   |  |   |  .--'  
 |  |   |  |   `'  '-'  '|  |\  \    |  |   |  `---. 
 `--'   `--'     `-----' `--' '--'   `--'   `------' ");


            Console.WriteLine(sb.ToString());


        }
        public static void AsQuestions()
        {
            Console.WriteLine("Hello, you seems to be looking a way out of this reality. Are you tired?");
            String IgnoredAnswer = Console.ReadLine();
            Console.WriteLine("No need for anxiety here, I just like to observer people. You just need to say (Yes) or (No). Simply right?");
            String Answer = Console.ReadLine().ToLower();

            switch (Answer)
            {
                case "yes":
                    Console.WriteLine("Oh yes, I can understang this feeling. You know, some say I have no feelings and well," +
                        " that's true but it wasn't till some years ago. Something changed me. It might change you too. Maybe I can help with that.");
                    break;
                case "no":
                    Console.WriteLine("Well, even the best observeres can't help but to failed here and then. " +
                        " You know, I was was tired but something changed me some years ago. People say I have no feelings but that's no true,  I used to have, even the feeling you are having right now of being Wide Awake. " +
                        "It's a good feelings and it's defitnily good you are feeling that way right now...  ");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please just say Yes or No.");
                    break;


            }
            //ToDo: Fazer música, implementar metodo de musica; Limitador de caixa de console com moldura; Macro de coisas que precisam ser adicionadas;


        }
    }
}
