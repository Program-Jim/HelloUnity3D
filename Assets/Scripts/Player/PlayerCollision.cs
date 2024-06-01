using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle") || collisionInfo.collider.GetComponent<Obstacle>() != null)
        {
            //Debug.Log("We hit Obstacle! --Player");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}