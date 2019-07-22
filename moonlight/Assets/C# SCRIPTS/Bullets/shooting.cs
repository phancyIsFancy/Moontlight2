using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour
{
    public squirrelystats stats;
    public BattleManager battle;
    public GameObject shootpoint;
    public GameObject SquirrelJuices;
    public GameObject HotSquirrelJuices;
    public GameObject SpreadSquirrelShot;
    public GameObject StormSquirrelJuices;
    public GameObject OMEGASQUIRRELJUICES;
    public GameObject BouncySquirrelJuices;
    private int cooldown;
    private int cooldownmax;
    private bool readyToFire;
    public void Start()
    {
        stats = gameObject.GetComponent<squirrelystats>();
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            stats.wepontype = StormSquirrelJuices;      //put the name of the wepon testing in here
        }
        cooldown -= 1;
        if(cooldown <= 0)
        {
            readyToFire = true;
            cooldown = cooldownmax;
        }
        if (Input.GetMouseButton(0) && readyToFire == true)
        {
            Shoot();
            readyToFire = false;
        }
    }
    public void Shoot()
    {
        if (stats.wepontype.name == "Squirrel Juices")
        {
            cooldownmax = 30;
            Instantiate(stats.wepontype, shootpoint.transform.position, shootpoint.transform.rotation);            
        }
        if (stats.wepontype.name == "Steamy Squirrel Juices")
        {
            cooldownmax = 60;
            Instantiate(stats.wepontype, shootpoint.transform.position, shootpoint.transform.rotation);
        }
        if (stats.wepontype.name == "Squirrely Spread Shot")
        {
            cooldownmax = 25;
            Instantiate(stats.wepontype, shootpoint.transform.position, shootpoint.transform.rotation);
        }
        if (stats.wepontype.name == "Squirrely Shatter Storm")
        {
            cooldownmax = 40;
            Instantiate(stats.wepontype, shootpoint.transform.position, shootpoint.transform.rotation);
        }
        if (stats.wepontype.name == "Bouncy Squirrel Nuts")
        {
            cooldownmax = 20;
            Instantiate(stats.wepontype, shootpoint.transform.position, shootpoint.transform.rotation);
        }
        if (stats.wepontype.name == "OMEGA SQUIRRELS")
        {
            cooldownmax = 5;
            Instantiate(stats.wepontype, shootpoint.transform.position, shootpoint.transform.rotation);
        }
    }
}