using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMatController : MonoBehaviour
{
    public Material player1, player2, player3, player4;
    private MeshRenderer Player;
    public string sceneName;

    void Start()
    {
        //Debug.Log(sceneName);
        //if ()
        Player = GetComponent<MeshRenderer>();
        
    }

    
    void Update()
    {
        Debug.Log(sceneName);
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Player.material = player1;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            Player.material = player2;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            Player.material = player3;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            Player.material = player4;
    }

    public void GetSceneINFO()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }
}
