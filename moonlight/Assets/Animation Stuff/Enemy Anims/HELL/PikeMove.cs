using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikeMove : MonoBehaviour
{
    public EnemyAI ai;
    Rigidbody rb;
    private void Awake()
    {
        ai = GameObject.Find("placeholderenemy (19)(Clone)").GetComponent<EnemyAI>();
        rb = GetComponent<Rigidbody>();
        
        if(ai.down == true)
        {
            StartCoroutine(Move(-250));
        }
        else
        {
            StartCoroutine(Move(250));
        }
    }
    IEnumerator Move(float directionandSpeed)
    {
        if(name == "UnholyPike")
        {
            
        }
        else
        {
            rb.AddRelativeForce(0, directionandSpeed, 0);
            yield return new WaitForSeconds(10);
            if(name == "UnholyPike(Clone)")
            {
                 Destroy(gameObject);
            }
        }
        
       
    }
}
