namespace ui
{
    using game;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;
    
    public class GameUi : MonoBehaviour
    {
        [SerializeField]
        private Button loadScene;

        [SerializeField]
        private LevelStateHandler levelStateHandler;
        
        [SerializeField]
        private string sceneName;
    
        private void OnEnable()
        {
            SetLoadSceneButton();

            loadScene.onClick.AddListener(LoadScene);
        }

        private void OnDisable()
        {
            if (levelStateHandler)
            {
                levelStateHandler.OnLevelComplete -= ShowLoadButton;
            }

            loadScene.onClick.RemoveListener(LoadScene);
        }

        private void SetLoadSceneButton()
        {
            if (levelStateHandler == false)
            {
                loadScene.gameObject.SetActive(true);
                
                return;
            }

            loadScene.gameObject.SetActive(false);

            levelStateHandler.OnLevelComplete += ShowLoadButton;
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
