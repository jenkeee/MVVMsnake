using MyMVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;


namespace MyMVVM.View
{
    internal sealed class Move : MonoBehaviour
    {
        [SerializeField] private Button _button;
        private Vector2 _direction;
        private IPosViewModel _posViewModel;


        public void Initialize(IPosViewModel posViewModel)
        {            
            _posViewModel = posViewModel;
             _button.onClick.RemoveAllListeners();
             _button.onClick.AddListener(() => _posViewModel.ApplyMove(_direction.x, _direction.y));
        }
    }
}