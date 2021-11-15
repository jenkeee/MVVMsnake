using System;
using MyMVVM.Model;

namespace MyMVVM.ViewModel
{
    public interface IPosViewModel
    {
        IPosModel PosModel { get; }        
        bool IsDead { get; }
        void ApplyMove(float posX, float posY);
        event Action<float, float> OnDirChange;
    }
}