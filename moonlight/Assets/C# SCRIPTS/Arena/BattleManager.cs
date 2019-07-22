using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public int hpbar;
    public bool hpbartrue;
    public bool fighttyper;
    public GameObject Encountered;
    // this is for the hp bar stuff
    public EncounterManager encounter;
    public GameObject SpawnPoint;
    public bool summonOn;
    private int bossdifficulty;
    public bool infight;
    public int enemiesAlive;
    public void Start()
    {
        encounter = gameObject.GetComponent<EncounterManager>();
    }
    public void Update()
    {
        if(hpbar <= 0)
        {

        }
    }
    public void MakeEnemies(bool fighttype, int AmountToSpawnEnemies, GameObject Encounteredboy) //false for encounter true for boss
    {
        fighttyper = true;
        if (Encounteredboy.name == "placeholderenemy (3)")
        {
            AmountToSpawnEnemies = 1;
        }
        if (Encounteredboy.name == "placeholderenemy (4)")
        {                                                                           //the number on the end is -1 of what the actual enemy number is
            AmountToSpawnEnemies = 1;
        }
        if (Encounteredboy.name == "placeholderenemy (19)")
        {
            AmountToSpawnEnemies = 1;
        }       
        if (fighttype == true)
        {
            Instantiate(Encounteredboy, SpawnPoint.transform.position, Quaternion.identity);
        }
        enemiesAlive += AmountToSpawnEnemies;
        Encountered = Encounteredboy;
        if (fighttype == false)
        {
            for(var i = 0; i < AmountToSpawnEnemies; i++)
            {
                Instantiate(Encounteredboy, SpawnPoint.transform.position, Quaternion.identity);
            }           
        }
    }
}
