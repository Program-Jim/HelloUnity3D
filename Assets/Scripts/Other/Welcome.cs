using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("START!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}