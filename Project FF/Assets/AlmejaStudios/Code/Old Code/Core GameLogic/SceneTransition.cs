using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public string SceneToLoad;
    public void LoadScene()
    {
        SceneManager.LoadSceneAsync(SceneToLoad);
    }
    
    public void Pause()
    {
        Time.timeScale = 0f;
    }
    
    public void Resume()
    {
        Time.timeScale = 1f;
    }
    
    public void Quit()
    {
        Application.Quit();
    }

}
