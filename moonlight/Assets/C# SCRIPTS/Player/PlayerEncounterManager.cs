using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEncounterManager : MonoBehaviour
{
    public EnemyTypeOnEncounter placeholder;
    public int difficultyReceived;
    public EncounterManager encounter;
    public EncounterStats statsE;
    public void Start()
    {
        encounter = GameObject.Find("EventSystem ").GetComponent<EncounterManager>();
    }
    public void Updatestuff(int difficulty)
    {
        difficultyReceived = difficulty;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EncounterEnemy")
        {
            statsE = other.gameObject.GetComponent<EncounterStats>();
            placeholder = other.gameObject.GetComponent<EnemyTypeOnEncounter>();
            encounter.typeE = other.gameObject.GetComponent<EnemyTypeOnEncounter>();
            encounter.OnEncounterEnter(placeholder.SummonEnemy, false, difficultyReceived);
        }
    }
}
