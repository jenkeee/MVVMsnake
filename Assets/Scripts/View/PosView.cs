using MyMVVM.ViewModel;
using UnityEngine;

namespace MyMVVM.View
{
    internal sealed class PosView : MonoBehaviour
    {
        [SerializeField] private Transform _transform;

        public bool _deadOrNot;
        private IPosViewModel _posViewModel;

        public void Initialize(IPosViewModel posViewModel) //pishem method inicial
        {
            _posViewModel = posViewModel;
            _posViewModel.OnDirChange += OnDirChange;
            OnDirChange(_posViewModel.PosModel.MoveX, _posViewModel.PosModel.MoveY);            
        }

        private void OnDirChange(float moveX, float moveY) //pishem method OnDirChange
        {
            _transform.position = _posViewModel.IsDead ? new Vector2(0,0) : new Vector2(moveX, moveY);            
            _deadOrNot = _posViewModel.IsDead;
        }

        ~PosView() // Что это? деструктор.. он запутал
        {
            _posViewModel.OnDirChange -= OnDirChange;
        }
    }
}