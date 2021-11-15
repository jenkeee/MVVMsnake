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
            var posModel = new PosModel(0,0); 
            var posViewModel = new PosViewModel(posModel); 
            FindObjectOfType<PosView>().Initialize(posViewModel); 
            FindObjectOfType<MoveUP>().Initialize(posViewModel);
            FindObjectOfType<MoveDown>().Initialize(posViewModel);
            FindObjectOfType<MoveLeft>().Initialize(posViewModel);
            FindObjectOfType<MoveRight>().Initialize(posViewModel);
        }
    }
}