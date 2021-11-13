using System;
using MyMVVM.Model;

namespace MyMVVM.ViewModel
{
    public interface IPosViewModel
    {
        IPosModel PosModel { get; }
        bool IsDead { get; }
        void ApplyMove(float moveX, float moveY);
        event Action<float, float> OnDirChange;
    }
}
