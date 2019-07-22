using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E5laserMovement : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    private int lifetime = 100;
    public bool killable;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Squirrel Hitbox")
        {
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        player = GameObject.Find("Squirrel placeholder Stats");
        transform.LookAt(player.transform.position);
        rb = GetComponent<Rigidbody>();
               
    }
    public void Update()
    {
        transform.LookAt(player.transform.position);
        if (lifetime <= 0 && killable == true)
        {
            Destroy(gameObject);
        }
        if (gameObject.name == "E5laser(Clone)")
        {
            killable = true;
            rb.AddRelativeForce(0f, 0f, 150f);
            lifetime -= 1;
        } 
        else
        {
            killable = false;
        }
    }
}
