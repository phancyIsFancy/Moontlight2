using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullChildKiller : MonoBehaviour
{
    private void Update()
    {
        if (transform.childCount <= 0 && transform.parent == null) 
        {
            Destroy(gameObject);
        }
    }
}
