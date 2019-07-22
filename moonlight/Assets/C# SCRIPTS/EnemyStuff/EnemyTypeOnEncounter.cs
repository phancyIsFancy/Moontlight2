using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeOnEncounter : MonoBehaviour
{
    public GameObject SummonEnemy;
    private int randomEnemy;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;
    public GameObject E5;
    public GameObject E6;
    public GameObject E7;
    public GameObject E8;
    public GameObject E9;
    public GameObject E10;
    public GameObject E11;
    public GameObject E12;
    public GameObject E13;
    public GameObject E14;
    public GameObject E15;
    public GameObject E16;
    public GameObject E17;
    public GameObject E18;
    public GameObject E19;
    public GameObject E20;
    private void Awake()
    {
        randomEnemy = Random.Range(20, 20); // 2, 3, 4, 13, 14, 19, 20
        if (randomEnemy == 2)
        {
            SummonEnemy = E2;
        }
        if (randomEnemy == 3)
        {
            SummonEnemy = E3;
        }
        if (randomEnemy == 4)
        {
            SummonEnemy = E4;
        }
        if (randomEnemy == 5)
        {
            SummonEnemy = E5;
        }
        if (randomEnemy == 6)
        {
            SummonEnemy = E6;
        }
        if (randomEnemy == 7)
        {
            SummonEnemy = E7;
        }
        if (randomEnemy == 8)
        {
            SummonEnemy = E8;
        }
        if (randomEnemy == 9)
        {
            SummonEnemy = E9;
        }
        if (randomEnemy == 10)
        {
            SummonEnemy = E10;
        }
        if (randomEnemy == 11)
        {
            SummonEnemy = E11;
        }
        if (randomEnemy == 12)
        {
            SummonEnemy = E12;
        }
        if (randomEnemy == 13)
        {
            SummonEnemy = E13;
        }
        if (randomEnemy == 14)
        {
            SummonEnemy = E14;
        }
        if (randomEnemy == 15)
        {
            SummonEnemy = E15;
        }
        if (randomEnemy == 16)
        {
            SummonEnemy = E16;
        }
        if (randomEnemy == 17)
        {
            SummonEnemy = E17;
        }
        if (randomEnemy == 18)
        {
            SummonEnemy = E18;
        }
        if (randomEnemy == 19)
        {
            SummonEnemy = E19;
        }
        if (randomEnemy == 20)
        {
            SummonEnemy = E20;
        }
    }
}
