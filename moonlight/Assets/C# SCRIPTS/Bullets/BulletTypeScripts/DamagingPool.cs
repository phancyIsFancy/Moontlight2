using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingPool : MonoBehaviour
{
    private int lifetime = 200;
    public void Update()
    {
        transform.position = new Vector3(transform.position.x, -.52f, transform.position.z);
        lifetime -= 1;
        if (lifetime <= 0 && transform.parent.name != "DamagingPool") 
        {
            Destroy(gameObject);
        }
    }
}
