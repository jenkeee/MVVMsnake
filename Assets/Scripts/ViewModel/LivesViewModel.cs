using System;
using MyMVVM.Model;

namespace MyMVVM.ViewModel
{
    internal sealed class LivesViewModel : ILivesViewModel
    {
        private bool _isDead;
        public event Action<int> OnLivesCountChange;
        public ILivesModel LivesModel { get; }

        public bool LivesOut => _isDead;

        public LivesViewModel(ILivesModel livesModel)
        {
            LivesModel = livesModel;
        }


        public void MinusLive(int minuslives)
        {
            LivesModel.CurrentLives -= minuslives;
            if (LivesModel.CurrentLives <= 0)
            {
                _isDead = true;
            }
            OnLivesCountChange?.Invoke(LivesModel.CurrentLives);
        }
    }
}

