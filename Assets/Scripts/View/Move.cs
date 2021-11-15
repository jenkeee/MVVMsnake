using MyMVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;

namespace MyMVVM.View
{
    internal sealed class Move : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Vector2 _move;
        private IPosViewModel _posViewModel;

        public void Initialize(IPosViewModel posViewModel)
        {
            _posViewModel = posViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _posViewModel.ApplyMove(_move.x,_move.y));
        }
    }
}
