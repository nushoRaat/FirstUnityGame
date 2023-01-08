using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public Rigidbody rb;
    public playerMovement movement;
    
    public GameObject levelCompleteUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);
           //Restart();
        }
       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void completeLevel()
    {
        //Debug.Log("Level Won");
        
        levelCompleteUI.SetActive(true);
        //Invoke("stopPlayer",1f);

    }
    public void stopPlayer()
    {

        movement.enabled = false;
        //rb.velocity = Vector3.zero;
    }


}
