using MyMVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;


namespace MyMVVM.View
{
    internal sealed class MoveUp : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _moveUp;
        private IPosViewModel _posViewModel;

        public void Initialize(IPosViewModel hpViewModel)
        {
            _posViewModel = hpViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _posViewModel.ApplyMove(0,_moveUp));            
        }
    }
}