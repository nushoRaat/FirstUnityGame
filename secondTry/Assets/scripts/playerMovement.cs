using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float ff = 500f;
    public float sf = 200f;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void FixedUpdate()
    {
        // if (Input.GetKey("w"))
        // {
        //      rb.AddForce(0,0,ff * Time.deltaTime);
        // }
       
        rb.AddForce(0,0,ff * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sf *Time.deltaTime , 0 , 0,ForceMode.VelocityChange);                                       
        }
         if(Input.GetKey("a"))
        {
            rb.AddForce(-sf *Time.deltaTime , 0 , 0,ForceMode.VelocityChange);                                       
        }
        if(rb.position.y< -0.5f)
        {
             FindObjectOfType<GameManager>().EndGame();
        }
    }
}
 