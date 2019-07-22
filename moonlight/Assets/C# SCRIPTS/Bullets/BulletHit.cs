using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public BulletMovement move;
    public bool hit;
    public void Start()
    {
        move = transform.parent.GetComponent<BulletMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "playerDamager")
        {
            move.DIE();
        }      
    }
}
