using MyMVVM.Model;
using MyMVVM.ViewModel;
using MyMVVM.View;
using UnityEngine;

namespace MyMVVM
{
    internal sealed class Lives : MonoBehaviour
    {
        private void Start()
        {
            var livesModel = new LivesModel(3);
            var livesViewModel = new LivesViewModel(livesModel);
            FindObjectOfType<LivesView>().Initialize(livesViewModel);
            FindObjectOfType<MinusLive>().Initialize(livesViewModel);
        }
    }
}