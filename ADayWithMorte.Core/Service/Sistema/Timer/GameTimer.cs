using ADayWithMorte.Core.Interface.IService.ISistem;
using System.Diagnostics;

namespace ADayWithMorte.Shared.Sistema.Timer
{
    public class GameTimer : IGameTimer
    {
        private Stopwatch stopwatch;
        private TimeSpan initialTime;

        public GameTimer(DateTime? startTime = null)
        {
            stopwatch = new Stopwatch();
            initialTime = startTime.HasValue ? DateTime.Now - startTime.Value : TimeSpan.Zero;
        }

        public void Start()
        {
            stopwatch.Start();

            new Thread(() =>
            {
                while (true)
                {
                    TimeSpan ts = stopwatch.Elapsed + initialTime;
                    Thread.Sleep(1000);
                }
            }).Start();
        }

        public TimeSpan GetElapsedTime()
        {
            return stopwatch.Elapsed;
        }
    }
}
