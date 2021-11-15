using MyMVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;


namespace MyMVVM.View
{
    internal sealed class MinusLive : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private int _damage;
        private ILivesViewModel _livesViewModel;

        public void Initialize(ILivesViewModel livesViewModel)
        {
            _livesViewModel = livesViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _livesViewModel.MinusLive(_damage));
        }
    }
}