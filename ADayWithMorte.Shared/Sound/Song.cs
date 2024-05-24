using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ScaleTune()
        {
            Console.Beep(D, semibreve);
            Console.Beep(E, semibreve);
            Console.Beep(F, semibreve);
            Console.Beep(G, semibreve);
            Console.Beep(A, semibreve);
            Console.Beep(B, semibreve);
            Console.Beep(C2, breve);
        }

        public void Example()
        {


            //PARTE 1

            Thread.Sleep(2000);

            Console.Beep(100, 350);
            Thread.Sleep(frequency);

            Console.Beep(130, 700);
            Thread.Sleep(frequency);

            Console.Beep(150, 175);
            Thread.Sleep(frequency);

            Console.Beep(200, 165);
            Thread.Sleep(frequency);

            Console.Beep(659, 190);
            Thread.Sleep(frequency);

            Console.Beep(987, 450);
            Thread.Sleep(frequency);

            Console.Beep(880, 530);
            Thread.Sleep(frequency);

            Console.Beep(740, 550);
            // Thread.Sleep(frequency);

            //PARTE 2

            Console.Beep(659, 500);
            Thread.Sleep(frequency);

            Console.Beep(800, 300);
            Thread.Sleep(frequency);

            Console.Beep(740, 300);
            Thread.Sleep(frequency);

            Console.Beep(659, 400);
            Console.Beep(659, 200);

            Console.Beep(493, 600);
            // Thread.Sleep(frequency);

            //PARTE 3

            Thread.Sleep(frequency);
            Console.Beep(493, 250);
            Thread.Sleep(frequency);

            Console.Beep(659, 400);
            Thread.Sleep(frequency);

            Console.Beep(783, 150);
            Thread.Sleep(frequency);

            Console.Beep(740, 230);
            Thread.Sleep(frequency);

            Console.Beep(659, 400);
            Thread.Sleep(frequency);

            //PARTE 4

            Console.Beep(987, 300);
            Thread.Sleep(frequency);

            Console.Beep(1174, 600);
            Thread.Sleep(frequency);

            Console.Beep(1174, 350);
            Thread.Sleep(frequency);

            Console.Beep(1046, 550);
            // Thread.Sleep(frequency);

            //PARTE 5

            Console.Beep(880, 500);
            Thread.Sleep(frequency);

            Console.Beep(1046, 400);
            Thread.Sleep(frequency);

            Console.Beep(987, 300);
            Thread.Sleep(frequency);

            Console.Beep(987, 200);
            Thread.Sleep(frequency);

            Console.Beep(659, 300);
            Thread.Sleep(frequency);

            Console.Beep(783, 600);
            Thread.Sleep(frequency);

            Console.Beep(659, 900);
            Thread.Sleep(frequency);

        }
        public void Intro()
        {
            int[] frequencias = { 300, 800, 457, 289, 100, 90, 80, 70, 40

                };

            int[] duracoes = { breve, breve, semibreve,frequency, semibreve, breve, breve, breve, semibreve

       };

            // Reproduzir as notas com um atraso entre elas
            for (int i = 0; i < frequencias.Length; i++)
            {
                Console.Beep(frequencias[i], duracoes[i]);

                    Thread.Sleep(minima);
                


            }
        }
    }
}
