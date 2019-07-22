using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelyShatterStorm : MonoBehaviour
{
    private bool cantdoagain;
    private Rigidbody rb;
    private float stormdelay = 200;
    public GameObject ShatterShard;
    public float Xborder;
    public float Yborder;
    public float Zborder;
    private Vector3 parentAttatch;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "playerDamager") 
        {
            Storm();
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        stormdelay -= 1;
        if(cantdoagain == true)
        {
            stormdelay = 1;
        }
        if (stormdelay <= 0)
        {
            Storm();
            cantdoagain = true;
        }
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        ShatterShard = GameObject.Find("ShatterStormProj.");
        Yborder = gameObject.transform.position.y + 15f;
        for (var i = 0; i < 4; i++)
        {
            rb.AddRelativeForce(350, 0, 350);
        }
        
    }
    public void Storm()
    {
        for(var i = 0; i < 7; i++)
        {
            Instantiate(ShatterShard, new Vector3(transform.position.x + Random.Range(-5, 5), Yborder, transform.position.z + Random.Range(-5, 5)), Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
