using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using SFB;

public class MapEditor : MonoBehaviour
{
    public static string loadedMapPath;
    
    public void CreateMap()
    {
        Debug.Log("Create Map");
    }

    public void LoadMap()
    {
        Debug.Log("Load Map");
        string[] path = StandaloneFileBrowser.OpenFilePanel("Open a map", "", "", false);
        
        for (int i = 0; i < path.Length; i++)
        {
            Debug.Log(path[i]);
        }
    }

    public void Exit()
    {
        Debug.Log("Exit the map editor");
        SceneManager.LoadScene("Welcome");
    }

}
