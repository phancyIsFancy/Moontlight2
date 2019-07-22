using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public LevelManager level;
    public float xpEarned;
    public Text bossname;
    public string nameOfBoss;
    public GameObject placeholderI;
    public Image placeholder;
    public HpBarManager hpmanager;
    public GameObject barprefab;
    public float startingHp;
    public float hpPercent;
    public Image bar;
    public Image[] barfilled;
    public GameObject player;
    public NavMeshAgent agent;
    [HideInInspector] public float hp;
    public bool E1type;
    public bool E2type;
    public bool E3type;
    public GameObject E3P;
    public bool E4type;
    public bool E5type;
    public bool E6type;
    public bool E7type;
    public bool E8type;
    public bool E9type;
    public bool E10type;
    public bool E11type;
    public bool E12type;
    public bool E13type;
    public bool E14type;
    public bool E15type;
    public bool E16type;
    public bool E17type;
    public bool E18type;
    public bool E19type;
    public bool E20type;
    private bool E5loop;           //this is for it following the player
    public GameObject E20p;
    public GameObject E20p1;
    public Vector3 HELLENCOUNTER;
    public float HELLplaceholderX;
    public float HELLplaceholderZ;
    public Animation anim2;
    public Animation anim;
    private Rigidbody rb;
    private Transform tr;
    private int randomnumberE20p;
    public bool down;
    private bool E20loop = false;
    public GameObject followbullets;
    public GameObject E5p;
    public int overtimecounter;
    public int overtimecounterCap;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Squirrely Shatter Storm")
        {
            hp -= 2;
        }
        if (collision.gameObject.name == "B.DamagingPool")
        {
            StartCoroutine(SquirrelHeat(5));
            print("oof");
        }
        if (collision.gameObject.name == "Cube")
        {
            hp -= 2;
        }
        if (collision.gameObject.name == "Cube (1)")
        {
            StartCoroutine(SquirrelHeat(3));
        }
        if (collision.gameObject.name == "BouncyProj.")
        {
            hp -= 5;
        }
        if (collision.gameObject.name == "SpreadProj. mid")
        {
            hp -= 4;
        }
        if (collision.gameObject.name == "SpreadProj. left")
        {
            hp -= 4;
        }
        if (collision.gameObject.name == "SpreadProj. right")
        {
            hp -= 4;
        }
        if (collision.gameObject.name == "ShatterStormProj.(Clone)")
        {
            hp -= 2.5f;
        }
        if (collision.gameObject.name == "Cube (5)")
        {
            hp -= 1;
        }
    }
    public IEnumerator SquirrelHeat(int amountofloop)
    {
        overtimecounterCap = amountofloop;
        hp -= 1;
        overtimecounter += 1;
        yield return new WaitForSeconds(1);
    }
    public IEnumerator WarpShoot()
    {
        E3type = false;
        for (var i = 0; i < 30; i++)
        {
            agent.SetDestination(player.transform.position);
            yield return new WaitForSeconds(1.5f);
            Instantiate(E3P, new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity);
            Instantiate(E3P, new Vector3(transform.position.x + 1, 0, transform.position.z + 1), Quaternion.identity);
            Instantiate(E3P, new Vector3(transform.position.x + 2, 0, transform.position.z + 2), Quaternion.identity);
            Instantiate(E3P, new Vector3(transform.position.x + 3, 0, transform.position.z + 3), Quaternion.identity);
            transform.position = new Vector3(player.transform.position.x - Random.Range(20, 30), transform.position.y, player.transform.position.z - Random.Range(20, 30));
            yield return new WaitForSeconds(1.5f);
        }
        Destroy(gameObject);
    }
    public IEnumerator BeginHell(float delaytime)
    {
        E20loop = true;
        E20type = false;
        for (var i = 0; i < 10; i++)
        {
            Instantiate(E20p, new Vector3(player.transform.position.x + 5, player.transform.position.y - 5, player.transform.position.z), Quaternion.identity);
            Instantiate(E20p, new Vector3(player.transform.position.x, player.transform.position.y - 5, player.transform.position.z + 5), Quaternion.identity);
            randomnumberE20p = Random.Range(1, 7);
            if(randomnumberE20p == 2)
            {
                down = true;
                Instantiate(E20p, new Vector3(player.transform.position.x, player.transform.position.y + 3, player.transform.position.z), Quaternion.identity);
            }
            else
            {
                down = false;
            }
            Instantiate(E20p, new Vector3(player.transform.position.x - 5, player.transform.position.y - 5, player.transform.position.z), Quaternion.identity);
            Instantiate(E20p, new Vector3(player.transform.position.x, player.transform.position.y - 5, player.transform.position.z - 5), Quaternion.identity);
            yield return new WaitForSeconds(delaytime);
        }
        yield return new WaitForSeconds(5);
        randomnumberE20p = Random.Range(1, 2);
        if(randomnumberE20p == 2)
        {
            StartCoroutine(BeginHell(.1f));
        }
        else
        {
            agent.speed = 999;
            agent.acceleration = 999;
            agent.SetDestination(player.transform.position);
            yield return new WaitForSeconds(1);
            agent.speed = 1;
            agent.acceleration = 1;
            StartCoroutine(BeginHell(.5f));
        }     
    }
    public IEnumerator AttackE4()
    {
        E4type = false;
        Instantiate(followbullets, transform.position,Quaternion.identity);
        followbullets.transform.parent = gameObject.transform;
        yield return new WaitForSeconds(1);
        StartCoroutine(AttackE4());
    }
    public IEnumerator ImpendingDeath(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
    public IEnumerator Zoom(int lifetime)
    {
        E14type = false;
        agent.SetDestination(new Vector3(Random.Range(200, -200), transform.position.y, Random.Range(200, -200)));
        yield return new WaitForSeconds(lifetime / 2);
    }
    public IEnumerator E5Attack()
    {
        E5loop = true;
        E5type = false;
        Instantiate(E5p, new Vector3(transform.position.x + 5, transform.position.y, transform.position.z), new Quaternion(transform.rotation.w, 0, transform.rotation.y, transform.rotation.z));
        Instantiate(E5p, new Vector3(transform.position.x - 5, transform.position.y, transform.position.z), new Quaternion(transform.rotation.w, 0, transform.rotation.y, transform.rotation.z));
        yield return new WaitForSeconds(2);
        StartCoroutine(E5Attack());
    }
    public void Update()
    {
        if(gameObject.tag == "playerDamager" && transform.parent == null)
        {
            hpPercent = hp * 100 / startingHp / 100;
            barfilled[1].fillAmount = hpPercent;
            bossname.text = nameOfBoss;
        }
        else
        {
            bossname.text = "";
            bar = null;
            barprefab = null;
            barfilled = null;
        }
        if (overtimecounter >= overtimecounterCap)
        {
            overtimecounter = 0;
            StopCoroutine(SquirrelHeat(0));
        }
        if (E5loop == true)
        {
            agent.SetDestination(player.transform.position);
        }
        if (name == "followbullet(Clone)")
        {
            agent.SetDestination(player.transform.position);
            agent.speed = 30;
            hp = 1;
        }
        else
        {
            if(name == "followbullet")
            {
                hp = 1;
            }
        }
        if (E20loop == true)
        {
            transform.LookAt(player.transform);
        }
        if (hp <= 0)
        {
            level.totalxp += xpEarned;
            Destroy(gameObject);
        } 
        HELLplaceholderX = player.transform.position.x;
        HELLplaceholderZ = player.transform.position.z;
        HELLplaceholderX -= 10;
        HELLplaceholderZ -= 5;
        HELLENCOUNTER = new Vector3(HELLplaceholderX, gameObject.transform.position.y, HELLplaceholderZ);
        if(gameObject.name == "UnholyPike (Clone)")
        {
            StartCoroutine(ImpendingDeath(.75f));
        }
        if (gameObject.name == "E20p1 (Clone)")
        {
            hp = 999;
            agent.SetDestination(player.transform.position);
            agent.speed = 50;
            hp -= 1;
        }
        if (E1type == true)
        {
            agent.SetDestination(player.transform.position);
            agent.speed = 20;
            
        }
        if (E2type == true)
        {
            agent.speed = 40;
            agent.SetDestination(player.transform.position); 
        }
        if (E3type == true)
        {
            StartCoroutine(WarpShoot());
        }
        if (E4type == true)
        {
            transform.LookAt(player.transform.position);
            StartCoroutine(AttackE4());
        }
        if (E5type == true)
        {
            agent.speed = 5;
            StartCoroutine(E5Attack());
        }
        if (E6type == true)
        {

        }
        if (E7type == true)
        {

        }
        if (E8type == true)
        {

        }
        if (E9type == true)
        {

        }
        if (E10type == true)
        {

        }
        if (E11type == true)
        {

        }
        if (E12type == true)
        {

        }
        if (E13type == true)       //finish this boi
        {
            agent.SetDestination(new Vector3(Random.Range(1 + transform.position.x, 100 + transform.position.x), transform.position.y, Random.Range(1 + transform.position.z, 100 + transform.position.z)));
        }
        if (E14type == true)
        {
            agent.speed = 999;
            StartCoroutine(Zoom(Random.Range(10, 30)));
        }
        if (E15type == true)
        {

        }
        if (E16type == true)
        {

        }
        if (E17type == true)
        {

        }
        if (E18type == true)
        {

        }
        if (E19type == true)         //and this fix it later make it difficult
        {
            agent.speed = 20;
            agent.SetDestination(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
        }
        if (E20type == true)
        {
            agent.speed = 1;
            StartCoroutine(BeginHell(.5f));
        }
    }
    private void Awake()
    {
        level = GameObject.Find("EventSystem ").GetComponent<LevelManager>();
        placeholder = GameObject.Find("Boss HealthBar Placeholder_bkgr").GetComponent<Image>();
    }
    public void Start()
    {
        barprefab = GameObject.Find("Boss HealthBar Placeholder_bkgr");
        if (gameObject.tag == "playerDamager" && transform.parent == null) 
        {
            placeholderI = Instantiate(barprefab, placeholder.transform.position, Quaternion.identity, FindObjectOfType<Canvas>().transform);
            bar = placeholderI.GetComponent<Image>();
            barfilled = placeholderI.GetComponentsInChildren<Image>();
            bossname = placeholderI.GetComponentInChildren<Text>();
        }
        E5p = GameObject.Find("E5laser");
        followbullets = GameObject.Find("followbullet");
        E20p = GameObject.Find("UnholyPike");
        E20p1 = GameObject.Find("BALL");
        E3P = GameObject.Find("Honk :3");
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        player = GameObject.Find("HitBox squirrel");
        agent = gameObject.GetComponent<NavMeshAgent>();
        if(transform.parent == null)
        {
            bar.enabled = true;
            barfilled[1].enabled = true;
            bossname.enabled = true;
        }
        if (name == "followbullet(Clone)")
        {
            StartCoroutine(ImpendingDeath(15f));
        }
        if (gameObject.name == "placeholderenemy(Clone)")
        {
            hp = 10;
            nameOfBoss = "";
            E1type = true; 
        }
        if (gameObject.name == "placeholderenemy (1)(Clone)")
        {
            hp = 20;
            E2type = true;
            anim = GameObject.Find("Capsule (1)").GetComponent<Animation>();
            anim2 = GameObject.Find("Capsule (2)").GetComponent<Animation>();
            nameOfBoss = "Driller";
            xpEarned = 50f;
        }
        else
        {
            anim = null;
            anim2 = null;
        }
        if (gameObject.name == "placeholderenemy (2)(Clone)")
        {
            hp = 30;
            E3type = true;
            nameOfBoss = "";
            xpEarned = 50f;

        }
        if (gameObject.name == "placeholderenemy (3)(Clone)")
        {
            hp = 40;
            E4type = true;
            nameOfBoss = "";
            xpEarned = 100;
        }
        if (gameObject.name == "placeholderenemy (4)(Clone)")
        {
            hp = 50;
            E5type = true;
            nameOfBoss = "";
            xpEarned = 150;
        }
        if (gameObject.name == "placeholderenemy (5)(Clone)")
        {
            hp = 60;
            E6type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (6)(Clone)")
        {
            hp = 70;
            E7type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (7)(Clone)")
        {
            hp = 80;
            E8type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (8)(Clone)")
        {
            hp = 90;
            E9type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (9)(Clone)")
        {
            hp = 100;
            E10type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (10)(Clone)")
        {
            hp = 125;
            E11type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (11)(Clone)")
        {
            hp = 130;
            E12type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (12)(Clone)")
        {
            hp = 140;
            E13type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (13)(Clone)")
        {
            hp = 1;
            E14type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (14)(Clone)")
        { 
            hp = 22;
            E15type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (15)(Clone)")
        {
            hp = 69;
            print("dabs unironically");
            E16type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (16)(Clone)")
        {
            hp = 150;
            E17type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (17)(Clone)")
        {
            hp = 75;
            E18type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (18)(Clone)")
        {
            hp = 200;
            E19type = true;
            nameOfBoss = "";
        }
        if (gameObject.name == "placeholderenemy (19)(Clone)")
        {
            hp = 300;
            E20type = true;
            nameOfBoss = "The Purple Eye";
            xpEarned = 600f;
        }
        startingHp = hp;
    }
}
