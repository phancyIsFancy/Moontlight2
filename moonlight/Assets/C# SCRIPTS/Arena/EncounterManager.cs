using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EncounterManager : MonoBehaviour
{
    public EnemyTypeOnEncounter typeE;
    public GameObject squirrel;
    public GameObject Pant; //Pant Pant Pant Pant Pant
    public GameObject Calvrett; //final boss with pants power
    public GameObject Calvrett_NoPants; // no pants first boss
    public GameObject Calvrett_WithOneLeg; //well it basically explains itself
    public BattleManager battle;
    public GameObject boss;
    public GameObject Enemy;
    public GameObject enemyEncountered;
    public GameObject bossEnountered;
    public int bossnumber = 1;
    public bool boss1;
    public bool boss2;
    public bool boss3;
    private int enemyDifficulty;
    private void Update()
    {
        if (bossnumber == 1)
        {
            boss = Calvrett_NoPants;
        }
        if(bossnumber == 2)
        {
            boss = Calvrett_WithOneLeg;
        }
        if(bossnumber == 3)
        {                                       //For this whole part if the boss# is set to true then the boss has been killed
            boss = Calvrett;
        }
        if (bossnumber == 4)
        {
            boss = Pant;
        }
        if (boss1 == true)
        {
            bossnumber = 2;
        }
        if (boss2 == true)
        {
            bossnumber = 3;
        }
        if (boss3 == true)
        {
            bossnumber = 0;
        }
    }
    private void Start()
    {
        battle = GetComponent<BattleManager>();
    }
    public void OnEncounterExit()
    {

    }
    public void OnEncounterEnter (GameObject EncounterObject, bool fighttype, int enemyR)  //true for boss false for encounter
    {
        print(EncounterObject);
        print(enemyR);
        if (fighttype == false)
        {
            battle.MakeEnemies(false, enemyR, EncounterObject);
        }
    }
}
