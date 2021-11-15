using System;
using MyMVVM.Model;

namespace MyMVVM.ViewModel
{
    internal sealed class PosViewModel : IPosViewModel
    {
        private bool _isDead;
        public event Action<float, float> OnDirChange;
        public IPosModel PosModel { get; }

        //public bool IsDead => _isDead;

        public bool IsDead 
        { 
            get { return _isDead; } 
        }

        public PosViewModel(IPosModel posModel)
        {
            PosModel = posModel;
        }


        public void ApplyMove(float moveX, float moveY)
        {
            PosModel.MoveX += moveX;
            PosModel.MoveY += moveY;

            if (PosModel.PosX <= 0)
            {
               // _isDead = true;
            }
            OnDirChange?.Invoke(PosModel.MoveX, PosModel.MoveY);
        }
    }
}
