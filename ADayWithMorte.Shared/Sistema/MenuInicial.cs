using NAudio.Wave;
using System.Text;


namespace ADayWithMorte.Shared.Sistema
{
    public class MenuInicial
    {
        internal void MakeTitle()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            int width = Console.WindowWidth;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"
              --------    -- --    ,--.   ,--.
             |   __   |  | '-.  \   \  `.'  / 
             |  |  \  '.-'-'  |  |.-')     /  
             |  |   ' | \| |_.'  (OO  \   /   
             |  |   / :  |  .-.  ||   /  /\_  
             |  '--'  /  |  | |  |`-./  /.__) 
             `-------'   `--' `--'  `--'      ");
            sb.AppendLine(@"  (`\ .-') /`       .-') _    ('-. .-. 
               `.( OO ),'      (  OO) )  ( OO )  / 
            ,--./  .--. ,--') /     '._  ,--. ,--. 
            |      |  | |  |OO)|'------_)|  | |  | 
            |  |   |  |,|  |  \'--.  .--'|  ._.  | 
            |  |/'\|  |_)  |(_/   |  |   |       | 
            |         |,|  |_.'   |  |   |  .-.  | 
            |   / \   (_|  |      |  |   |  | |  | 
            '--'   '--' `--'      `--'   `--' `--'");
            sb.AppendLine(@" _   .-')                _  .-')   .-') _     ('-.   
            ( '.( OO )_             ( \( -O ) (  OO) )  _(  OO)  
             ,--.   ,--.).-'),-----. ,------. /     '._(,------. 
             |   \./   |( O /  .-.  \|   __  \|'--...--)|  .---' 
             |         |/   |  | |  ||  |  | |'--.  .--'|  |     
             |  |\./|  |\_) |  |\|  ||  |_.' |   |  |  (|  '--.  
             |  |   |  |  \ |  | |  ||  .  '.'   |  |   |  .--'  
             |  |   |  |   `'  '-'  '|  |\  \    |  |   |  `---. 
             `--'   `--'     \_____/ `--' '--'   `--'   `------' ");

            Console.WriteLine(sb.ToString());
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
        }

        internal void PlayAudioFile()
        {
            string audioFile = @"..\..\..\..\ADayWithMorte.Shared\Sound\intro\teste.wav";

            using (var audioOutput = new WaveOutEvent())
            {
                using (var audioFileReader = new AudioFileReader(audioFile))
                {
                    audioOutput.Init(audioFileReader);
                    audioOutput.Play();

                    while (audioOutput.PlaybackState == PlaybackState.Playing)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }

                    audioOutput.Stop();
                }
            }
        }


        public void MakeMenu()
        {
            MakeTitle();
            PlayAudioFile();
            Util.PrintSkullBox("Hello World");

        }
    }
}
