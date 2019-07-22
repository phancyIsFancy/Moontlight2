using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class squirrelystats : MonoBehaviour
{
    public Image sr, sr1, sr2, sr3, sr4, sr5, sr6, sr7;
    public Image br, br1, br2, br3, br4, br5, br6, br7;
    public CameraDetatch camD;
    public int hp = 3;
    public int maxhp;
    public shooting shoot;
    public GameObject weponequiped;
    public GameObject wepontype;
    public bool alive;
    public int RandomWepon;
    public bool sheild;
    public void Start()
    {
        shoot = gameObject.GetComponent<shooting>();
        camD = GetComponentInChildren<CameraDetatch>();
    }
    public void Update()
    {
        if(maxhp < 1)
        {
            br.enabled = false;
        }
        else
        {
            br.enabled = true;
        }
        if (maxhp < 2)
        {
            br1.enabled = false;
        }
        else
        {
            br1.enabled = true;
        }
        if (maxhp < 3)
        {
            br2.enabled = false;
        }
        else
        {
            br2.enabled = true;
        }
        if (maxhp < 4)
        {
            br3.enabled = false;
        }
        else
        {
            br3.enabled = true;
        }
        if (maxhp < 5)
        {
            br4.enabled = false;
        }
        else
        {
            br4.enabled = true;
        }
        if (maxhp < 6)
        {
            br5.enabled = false;
        }
        else
        {
            br5.enabled = true;
        }
        if (maxhp < 7)
        {
            br6.enabled = false;
        }
        else
        {
            br6.enabled = true;
        }
        if (maxhp < 8)
        {
            br7.enabled = false;
        }
        else
        {
            br7.enabled = true;
        }
        if (maxhp == 0)
        {
            maxhp = 3;
        }
        if (hp == 69)
        {
            print("you have infinite power");
        }
        if (hp > maxhp)
        {
            hp = maxhp;
        }
        if (hp < 8)
        {
            sr7.enabled = false;
        }
        else
        {
            sr7.enabled = true;
        }
        if (hp < 7)
        {
            sr6.enabled = false;
        }
        else
        {
            sr6.enabled = true;
        }
        if (hp < 6)
        {
            sr5.enabled = false;
        }
        else
        {
            sr5.enabled = true;
        }
        if (hp < 5)
        {
            sr4.enabled = false;
        }
        else
        {
            sr4.enabled = true;
        }
        if (hp < 4)
        {
            sr3.enabled = false;
        }
        else
        {
            sr3.enabled = true;
        }
        if (hp < 3)
        {
            sr2.enabled = false;
        }
        else
        {
            sr2.enabled = true;
        }
        if (hp < 2)
        {
            sr1.enabled = false;
        }
        else
        {
            sr1.enabled = true;
        }
        if (hp < 1)
        {
            sr.enabled = false;
        }
        else
        {
            sr7.enabled = false;
        }
        if (hp <= 0)
        {
            camD.Detatch();
            Destroy(gameObject);
        }
    }
}
