using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    
    public void StartGame()
    {
        Debug.Log("START!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void OpenMapEditor()
    {
        Debug.Log("Open Map Editor");
        SceneManager.LoadScene("Editor");
    }

}