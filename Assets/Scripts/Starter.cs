using MVVM.Model;
using MVVM.View;
using MVVM.ViewModel;
using UnityEngine;


namespace MVVM
{
    internal sealed class Starter : MonoBehaviour
    {
        private void Start()
        {
            var hpModel = new HpModel(100); // using MVVM.Model;
            var hpViewModel = new HpViewModel(hpModel); //using MVVM.ViewModel;
            FindObjectOfType<HpView>().Initialize(hpViewModel); // using MVVM.View;
            FindObjectOfType<DoDmg>().Initialize(hpViewModel); // using MVVM.View;
        }
    }
}
