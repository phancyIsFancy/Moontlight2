using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public BulletHit hit;
    public float count;
    public Rigidbody rb;
    private float speed = 200f;
    private void Awake()
    {
        rb = GetComponentInChildren<Rigidbody>();
        hit = GetComponentInChildren<BulletHit>();
    }
    public void DIE()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        rb.AddRelativeForce(speed, 0, speed);
        count += 1f;
        if (count >= 100)
        {
            Destroy(gameObject);
        }
    }
}
