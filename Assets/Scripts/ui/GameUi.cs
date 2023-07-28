namespace ui
{
    using interactions;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;
    
    public class GameUi : MonoBehaviour
    {
        [SerializeField]
        private Button loadScene;

        [SerializeField]
        private SpriteButton showLoadButton;
        
        [SerializeField]
        private string sceneName;
    
        private void OnEnable()
        {
            SetLoadSceneButton();

            loadScene.onClick.AddListener(LoadScene);
        }

        private void OnDisable()
        {
            if (showLoadButton)
            {
                showLoadButton.OnClick -= ShowLoadButton;
            }

            loadScene.onClick.RemoveListener(LoadScene);
        }

        private void SetLoadSceneButton()
        {
            if (showLoadButton == false)
            {
                loadScene.gameObject.SetActive(true);
                
                return;
            }

            loadScene.gameObject.SetActive(false);

            showLoadButton.OnClick += ShowLoadButton;
        }

        private void LoadScene()
        {
            if (string.IsNullOrEmpty(sceneName))
            {
                return;
            }
            
            SceneManager.LoadSceneAsync(sceneName);
        }

        private void ShowLoadButton()
        {
            loadScene.gameObject.SetActive(true);
        }
    }
}
