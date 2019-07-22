using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public squirrelystats stats;
    public int timer = 0;
    public bool invunerable = false;
    public MeshRenderer mr;
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "playerDamager" && invunerable == false)
        {
            stats.hp -= 1;
            invunerable = true;
        }
        if(collision.gameObject.tag == "playerDamagerProjectile" && invunerable == false)
        {
            stats.hp -= 1;
            invunerable = true;
        }
    }
    public void Start()
    {
        mr = GameObject.Find("Squirrel placeholder Stats").GetComponent<MeshRenderer>();
        stats = GetComponentInParent<squirrelystats>();
    }
    IEnumerator Flash()
        {
            mr.enabled = false;
            yield return new WaitForSeconds(1);
            mr.enabled = true;
            timer += 1;
        }
    public void Update()
    {
        if (timer >= 5)
        {
            timer = 0;
            invunerable = false;
            StopCoroutine(Flash());
        }
        if (invunerable == true)
        {
            StartCoroutine(Flash());
        }
    }
}
