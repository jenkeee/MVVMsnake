using MyMVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;

namespace MyMVVM.View
{
    internal sealed class LivesView : MonoBehaviour
    {
        [SerializeField] private Transform _livesCount;
        private ILivesViewModel _livesViewModel;

        public void Initialize(ILivesViewModel livesViewModel) //обратимся к классу IHpViewModel который не относиться к view
        {
            _livesViewModel = livesViewModel;
            _livesViewModel.OnLivesCountChange += OnLivesCountChange;
            OnLivesCountChange(_livesViewModel.LivesModel.CurrentLives);
        }

        private void OnLivesCountChange(int currentLives)
        {
            _livesCount. = _livesViewModel.IsDead ? "X_X" : currentLives.ToString();
        }

        ~LivesView()
        {
            _livesViewModel.OnLivesCountChange -= OnLivesCountChange;
        }
    }
}
