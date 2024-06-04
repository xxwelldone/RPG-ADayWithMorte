namespace ADayWithMorte.Core.Interface.IService.ISistem
{
    public interface ISoundSystem
    {
        public Task TalkSound(CancellationToken ct);
        public void diceSound(int diceValue);
        public void PlayBackgroundSound(string audioFile);

    }
}