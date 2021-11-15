namespace MyMVVM.Model
{
    public interface ILivesModel
    {
        int MaxLives { get; }

        int CurrentLives { get; set; }
    }
}
