using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelySpreadShot : MonoBehaviour
{
    private Rigidbody rb;
    private bool moving;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "playerDamager")
        {
            Destroy(gameObject);
        }
    }
    public IEnumerator DeathTimer(float timetilldeath, GameObject killedObject)
    {
        yield return new WaitForSeconds(timetilldeath);
        Destroy(killedObject);
    }
    public void Update()
    {
        if(moving == true)
        {
            rb.AddRelativeForce(230f, 0, 230f);
        }
    }
    private void Start()
    {
        print("Yikes");
        rb = gameObject.GetComponent<Rigidbody>();
        if (gameObject.name == "SpreadProj. mid")
        {
            transform.parent = null;
            moving = true;
            StartCoroutine(DeathTimer(.5f, gameObject));
        }
        if (gameObject.name == "SpreadProj. left")
        {
            transform.parent = null;
            moving = true;
            StartCoroutine(DeathTimer(.50f, gameObject));
        }
        if (gameObject.name == "SpreadProj. right")
        {
            transform.parent = null;
            moving = true;
            StartCoroutine(DeathTimer(.50f, gameObject));
        }
        if (gameObject.name == "Squirrely Spread Shot(Clone)")
        {
            StartCoroutine(DeathTimer(.1f, gameObject));
        }
    }
}
