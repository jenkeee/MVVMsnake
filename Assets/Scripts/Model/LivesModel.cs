namespace MyMVVM.Model
{
    internal sealed class LivesModel : ILivesModel
    {
        public int MaxLives { get; }
        public int CurrentLives { get; set; }

        public LivesModel(int maxLives)
        {
            MaxLives = maxLives;
            CurrentLives = MaxLives;
        }
    }
}
