using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public squirrelystats hp;
    public int levelrewardnumber;
    public float totalxp;
    public float xpTillNextlvl;
    public float currentlevel;
    public Text lvltext;
    public Image bar;
    public Image fillbar;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            totalxp += 600;
        }
        if (totalxp > xpTillNextlvl)
        {
            totalxp = totalxp -= xpTillNextlvl;
            currentlevel += 1;
            if(levelrewardnumber == 2)
            {

            }
            else
            {
                levelrewardnumber += 1;
            }
        }
        if(currentlevel == 3 && levelrewardnumber < 3)
        {
            levelrewardnumber = 3;
            hp.hp = hp.maxhp;
            hp.maxhp += 1;
            hp.hp = hp.maxhp;
        }
        lvltext.text = "Level: " + currentlevel.ToString();
        xpTillNextlvl = currentlevel * 2000;
        fillbar.fillAmount = totalxp * 100 / xpTillNextlvl / 100;
    }
}
