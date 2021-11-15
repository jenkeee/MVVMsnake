namespace MyMVVM.Model
{
    internal sealed class PosModel : IPosModel    
    {
        public float PosX { get;}
        public float PosY { get;}
        public float MoveX { get; set; }
        public float MoveY { get; set; }

        public PosModel(float posX, float posY)
        {
            PosX = posX;
            PosY = posY;

            MoveX = posX;
            MoveY = posY;
        }
    }
}
