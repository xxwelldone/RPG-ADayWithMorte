
using System.Media;

namespace ADayWithMorte.Shared.Sound
{
    public class Song : ISong
    {
        public int C = 261;
        public int D = 294;
        public int E = 329;
        public int F = 349;
        public int G = 392;
        public int A = 440;
        public int B = 493;
        public int C2 = 523;

        // Define a duração das notas (em milissegundos)
        public int breve = 2000;
        public int semibreve = 1000;
        public int minima = 500;
        public int seminima = 250;
        public int frequency = 5;

        public void PlayHeartbeat()
        {
            Thread.Sleep(semibreve);

            Console.Beep(B, semibreve);
            Thread.Sleep(semibreve);
            Console.Beep(B, semibreve);
            Console.Beep(B, minima);
            Thread.Sleep(seminima);
            Console.Beep(A, minima);
            Thread.Sleep(minima);
        }

    }
}
