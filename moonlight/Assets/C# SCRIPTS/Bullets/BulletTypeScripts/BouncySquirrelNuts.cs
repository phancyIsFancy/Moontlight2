using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySquirrelNuts : MonoBehaviour
{
    private bool parent;
    public GameObject damagingPool;
    private Rigidbody rb;
    private int bouncecount;
    private int lifetime = 300;
    public IEnumerator ImpendingZoom(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        rb.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotation;
    }
    public void OnCollisionEnter(Collision other)
    {
        if(parent == false)
        {
            print(other.gameObject.name);
            if (other.gameObject.tag == "playerDamager")
            {
                Instantiate(damagingPool, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            if (other.gameObject.name == "Ground" && bouncecount != 3)
            {
                bouncecount += 1;
            }
            else
            {
                if (bouncecount >= 3)
                {
                    Instantiate(damagingPool, transform.position, Quaternion.identity);
                    Destroy(gameObject);
                }
            }
        }
    }
    public void Start()
    {
        if (parent == false)
        {
            StartCoroutine(ImpendingZoom(.2f));
            rb = GetComponent<Rigidbody>();
            damagingPool = GameObject.Find("DamagingPool");
            for(var i = 0; i < 4; i ++)
            {
                rb.AddRelativeForce(250, 0, 250);
            }
        }       
    }
    public void Update()
    {
        if(gameObject.name != "Bouncy Squirrel Nuts(Clone)")
        {
            parent = false;
        }
        else
        {
            parent = true;
        }
        lifetime -= 1;
        if (lifetime <= 0 && parent == false)
        {
            Instantiate(damagingPool, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
