using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterShard : SquirrelyShatterStorm
{
    public Vector3 randomboyo;
    public void Update()
    {
        if(transform.position.y <= -20 && gameObject.name == "ShatterStormProj.(Clone)")
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if (other.gameObject.tag == "playerDamager")
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        ShatterShard = gameObject;
    }
}
