using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [Header("Scene to Load")]
    public string sceneName;

    public void LoadScene()
    {
        if (sceneName == "Exit")
        {
            Application.Quit();
        }
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is empty!");
        }
    }
}
