using MyMVVM.ViewModel;
using UnityEngine;

namespace MyMVVM.View
{
    internal sealed class PosView : MonoBehaviour
    {
        [SerializeField] private Vector2 _pos;
        private IPosViewModel _posViewModel;
      


        public bool _isDead;
        

        public void Initialize(IPosViewModel posViewModel) 
        {
     
            _posViewModel = posViewModel;
            _posViewModel.OnDirChange += OnDirChange; // event Action<float> OnDirChange;
            OnDirChange(_posViewModel.PosModel.PosX, _posViewModel.PosModel.PosY);
        }

        private void OnDirChange(float posX, float posY)
        {
            transform.position = _posViewModel.IsDead ? _pos += new Vector2(0,1) : _pos += new Vector2(0,0);
        }

        ~PosView() // имя деструктора должно соотвествовать имени типа
        {
            _posViewModel.OnDirChange -= OnDirChange;
        }
    }
}