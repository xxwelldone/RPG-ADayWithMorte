using ADayWithMorte.Core.Interface.IService.ISistem;
using NAudio.Wave;


namespace ADayWithMorte.Shared.Sistema.LuckSistem
{
    public class DiceSistem
    {
        private readonly ISoundSystem _soundSystem;

        public DiceSistem(ISoundSystem soundSystem)
        {
            _soundSystem = soundSystem;
        }
        public int throwDice()
        {
            Random diceRandom = new Random();

            int dice = diceRandom.Next(1, 21);
            _soundSystem.diceSound(dice);
            Console.WriteLine($"Você tirou {dice}");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            return dice;
        }
    }
}

