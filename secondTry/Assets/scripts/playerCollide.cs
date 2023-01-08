using UnityEngine;

public class playerCollide : MonoBehaviour
{

    public playerMovement movement;
   // public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            //GetComponent<playerMovement>().enabled = false;
            Debug.Log("hit");
            FindObjectOfType<GameManager>().EndGame();

        }
         //Debug.Log("hit");

    }
}
