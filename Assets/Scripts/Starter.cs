using MyMVVM.Model;
using MyMVVM.ViewModel;
using MyMVVM.View;
using UnityEngine;

namespace MyMVVM
{
    internal sealed class Starter : MonoBehaviour
    {
        private void Start()
        {
            var posModel = new PosModel(1,5); 
            var posViewModel = new PosViewModel(posModel); 
            FindObjectOfType<PosView>().Initialize(posViewModel); 
            FindObjectOfType<Move>().Initialize(posViewModel); 
        }
    }
}