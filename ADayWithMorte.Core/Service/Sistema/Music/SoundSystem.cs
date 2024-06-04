using ADayWithMorte.Core.Interface.IService.ISistem;
using NAudio.Wave;

namespace ADayWithMorte.Core.Service.Sistema.Music
{
    public class SoundSystem : ISoundSystem
    {
        internal Task PlaySound(string audioFile, CancellationToken ct, bool waitForUserInput = false)
        {
            return Task.Run(() =>
            {
                using (var audioOutput = new WaveOutEvent())
                {
                    using (var audioFileReader = new AudioFileReader(audioFile))
                    {
                        audioOutput.Init(audioFileReader);
                        audioOutput.Play();

                        while (audioOutput.PlaybackState == PlaybackState.Playing)
                        {
                            if (ct.IsCancellationRequested || (waitForUserInput && Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
                            {
                                audioOutput.Stop();
                                break;
                            }
                        }
                    }
                }
            });
        }

        public Task TalkSound(CancellationToken ct)
        {
            string audioFile = @"..\..\..\..\ADayWithMorte.Shared\Sound\Talk\Talking.wav";
            return PlaySound(audioFile, ct);
        }

        public void diceSound(int diceValue)
        {
            var audioFile = diceValue > 11 ? @"..\..\..\..\ADayWithMorte.Shared\Sound\Dados\dice.wav" :
                @"..\..\..\..\ADayWithMorte.Shared\Sound\Dados\dice2.wav";
            PlaySound(audioFile, new CancellationToken());
        }

        public void PlayBackgroundSound(string audioFile)
        {
            PlaySound(audioFile, new CancellationToken(), true).Wait();
        }
    }
}
