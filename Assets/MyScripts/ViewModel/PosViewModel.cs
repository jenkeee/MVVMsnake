using System;
using MyMVVM.Model;


namespace MyMVVM.ViewModel
{
    internal sealed class PosViewModel : IPosViewModel
    {

        public bool _isDead;
        public event Action<float, float> OnDirChange;
        public IPosModel PosModel { get; }


        public bool IsDead => _isDead;       
        
          

        public PosViewModel(IPosModel posModel)
        {
            PosModel = posModel;
            //_isDead = posView._isDead;
        }


        public void ApplyMove(float posX, float posY)
        {
            PosModel.MoveX -= posX;
            PosModel.MoveY -= posY;

            if (PosModel.PosX <= 0)
            {
                _isDead = true;
            }
            OnDirChange?.Invoke(PosModel.MoveX, PosModel.MoveY);
        }
    }
}


