namespace ui
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;
    
    public class GameUi : MonoBehaviour
    {
        [SerializeField]
        private Button loadScene;
    
        [SerializeField]
        private string sceneName;
    
        private void OnEnable() 
        {
            loadScene.onClick.AddListener(LoadScene);
        }

        private void OnDisable()
        {
            loadScene.onClick.RemoveListener(LoadScene);
        }

        private void LoadScene()
        {
            if (string.IsNullOrEmpty(sceneName))
            {
                return;
            }
            
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}
