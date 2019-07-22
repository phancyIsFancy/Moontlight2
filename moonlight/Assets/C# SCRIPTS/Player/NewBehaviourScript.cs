using UnityEngine;

public class BiomeBroadcaster : MonoBehaviour
{
    public Rigidbody rb;
    public float movespeed = 1250f;
    
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(movespeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-movespeed * Time.deltaTime, 0, 0);
                                                                
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -movespeed * Time.deltaTime);

        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movespeed * Time.deltaTime);
        }

        

     


        //this is the script for waves of enemies!


         

    }
}