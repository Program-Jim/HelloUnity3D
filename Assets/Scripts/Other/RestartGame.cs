using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    //RG is short for RestartGame
    public void RG()
    {
        Debug.Log("RestartGame!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }
}