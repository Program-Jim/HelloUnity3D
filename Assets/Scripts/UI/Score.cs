using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    //SNM is short for Score Number 
    public float SNM = 0;
    // Update is called once per frame
    void Update()
    {
        SNM = player.position.z + 41;
        scoreText.text = SNM.ToString("0");
    }
}