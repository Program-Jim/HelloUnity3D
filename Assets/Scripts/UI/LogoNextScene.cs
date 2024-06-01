using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoNextScene : MonoBehaviour
{
    
    public void LogoLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
