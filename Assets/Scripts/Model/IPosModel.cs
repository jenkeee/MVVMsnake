namespace MyMVVM.Model
{
    public interface IPosModel
    {
        float PosX { get; }
        float PosY { get; }

        float MoveX { get; set; }
        float MoveY { get; set; }
    }
}
