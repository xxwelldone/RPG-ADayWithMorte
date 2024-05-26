using NAudio.Wave;


namespace ADayWithMorte.Shared.Sistema.LuckSistem
{
    public class DiceSistem
    {
        public int throwDice()
        {
            Random diceRandom = new Random();

            int dice = diceRandom.Next(1, 21);
            diceSound(dice);
            Console.WriteLine($"Você tirou {dice}");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            return dice;
        }

        internal void diceSound(int diceValue)
        {
            var audioFile = diceValue > 11 ? @"..\..\..\..\ADayWithMorte.Shared\Sound\Dados\dice.wav" :
                @"..\..\..\..\ADayWithMorte.Shared\Sound\Dados\dice2.wav";

            using (var audioOutput = new WaveOutEvent())
            {
                using (var audioFileReader = new AudioFileReader(audioFile))
                {
                    audioOutput.Init(audioFileReader);
                    audioOutput.Play();

                    while (audioOutput.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
        }



    }
}

