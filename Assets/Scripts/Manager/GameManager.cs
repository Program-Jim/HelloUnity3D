using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //gHE is short for gameHasEnded
    public bool gHE = false;
    //rD is short for restartDelay
    public float rD = 1f;
    //ComplevelUI is short for completeLevelUI
    public GameObject ComplevelUI;

    public PlayerMovement mm;

    public void CompleteLevel()
    {
        Debug.Log("LEVEL WON! --GameManager");
        mm.enabled = false;
        ComplevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (gHE == false)
        {
            gHE = true;
            Debug.Log("GAME OVER! --GameManager");
            mm.enabled = false;
            Invoke("Restart", rD);
            //Restart game
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}