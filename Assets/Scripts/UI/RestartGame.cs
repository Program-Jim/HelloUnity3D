using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public int targetSceneIndex;
    
    //RG is short for RestartGame
    public void RG()
    {
        Debug.Log("RestartGame!");
        SceneManager.LoadScene(targetSceneIndex);
    }
}