using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile3 : MonoBehaviour
{
    public BulletHit hit;
    public Rigidbody rb;
    private float speed = 100f;
    private int lifetime = 50;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        hit = GetComponentInChildren<BulletHit>();
    }
    private void Update()
    {
        if(gameObject.name != "Honk :3(Clone)")
        {
            lifetime = 9999;
        }
        lifetime -= 1;
        rb.AddRelativeForce(speed, 0, speed);
        if(lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
