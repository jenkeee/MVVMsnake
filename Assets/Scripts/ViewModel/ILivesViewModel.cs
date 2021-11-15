using System;
using MyMVVM.Model;

namespace MyMVVM.ViewModel
{
    public interface ILivesViewModel
    {
        ILivesModel LivesModel { get; }   
        bool LivesOut { get; }
        void MinusLive(int minusLive);
        event Action<int> OnLivesCountChange;
    }
}
