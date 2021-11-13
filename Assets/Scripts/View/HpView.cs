using MVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;

namespace MVVM.View
{
    internal sealed class HpView : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private IHpViewModel _hpViewModel;

        public void Initialize(IHpViewModel hpViewModel) //��������� � ������ IHpViewModel ������� �� ���������� � view
        {
            _hpViewModel = hpViewModel;
            _hpViewModel.OnHpChange += OnHpChange;
            OnHpChange(_hpViewModel.HpModel.CurrentHp);
        }

        private void OnHpChange(float currentHp)
        {
            _text.text = _hpViewModel.IsDead ? "X_X" : currentHp.ToString();
        }

        ~HpView()
        {
            _hpViewModel.OnHpChange -= OnHpChange;
        }
    }
}
