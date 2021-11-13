using MyMVVM.Model;
using MyMVVM.View;
using MyMVVM.ViewModel;
using UnityEngine;


namespace MyMVVM
{
    internal sealed class startMyMVVM : MonoBehaviour
    {
        private void Start()
        {
            var posModel = new PosModel(0,0);
            var posViewModel = new PosViewModel(posModel);
            FindObjectOfType<PosView>().Initialize(posViewModel);
            FindObjectOfType<MoveUp>().Initialize(posViewModel);
            
            /*
            var hpModel = new HpModel(100); // using MVVM.Model;
            var hpViewModel = new HpViewModel(hpModel); //using MVVM.ViewModel;
            FindObjectOfType<HpView>().Initialize(hpViewModel); // using MVVM.View;
            FindObjectOfType<DoDmg>().Initialize(hpViewModel); // using MVVM.View;*/
        }
    }
}
