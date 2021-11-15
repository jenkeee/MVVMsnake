using System;
using MyMVVM.Model;
using UnityEngine;

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
            Debug.Log(PosModel.MoveX);
            if (PosModel.MoveX <= -9 || PosModel.MoveX >= 9)
            {
                _isDead = true;
            }
            else if (PosModel.MoveY <= -5 || PosModel.MoveY >= 5)
            {
                _isDead = true;
            }

            OnDirChange?.Invoke(PosModel.MoveX, PosModel.MoveY);
        }
    }
}
