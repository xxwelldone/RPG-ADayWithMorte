namespace ADayWithMorte.Core.Interface.IService.ISistem
{
    public interface IGameTimer
    {
        void Start();
        public TimeSpan GetElapsedTime();
    }
}
