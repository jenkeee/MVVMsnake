using MyMVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;

namespace MyMVVM.View
{
    internal sealed class LivesView : MonoBehaviour
    {
       // [SerializeField] private Transform _livesCount;
        [SerializeField] private GameObject _livesPrefab;
        [SerializeField] private Text _text;
        private ILivesViewModel _livesViewModel;

        public void Initialize(ILivesViewModel livesViewModel) //обратимся к классу IHpViewModel который не относиться к view
        {
            _livesViewModel = livesViewModel;
            _livesViewModel.OnLivesCountChange += OnLivesCountChange;            
            LoadLiveImage(_livesViewModel.LivesModel.CurrentLives);
            OnLivesCountChange(_livesViewModel.LivesModel.CurrentLives);
        }

        private void OnLivesCountChange(int currentLives)
        {
            if (_livesViewModel.LivesOut)
            {
                _text.text = "X_X ";
                for (int i = 0; i < transform.childCount; i++)
                {
                    GameObject tempObg;
                    tempObg = transform.GetChild(i).gameObject;
                    tempObg.gameObject.SetActive(false);
                }
               
            }
            else
            {
                _text.text = currentLives.ToString();
                if (currentLives < transform.childCount-1) CurrentLiveImage(currentLives);
            }

        }

        private void LoadLiveImage(int currentLives)
        {
            for (int i = 0; i < currentLives; i++)
            {
                var imgLives = GameObject.Instantiate(_livesPrefab, new Vector3(0, 0, 0), Quaternion.identity).transform;
                imgLives.SetParent(transform);
                imgLives.name = $"Live : {i}";
                imgLives.localScale = new Vector3(1, 1, 1);
            }
        }

        private void CurrentLiveImage(int currentLives)
        {
            GameObject currentLivesImage;
            currentLivesImage = transform.GetChild(currentLives+1).gameObject;
            currentLivesImage.SetActive(false);            
        }


            ~LivesView()
        {
            _livesViewModel.OnLivesCountChange -= OnLivesCountChange;
        }
    }
}
