using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterStats : MonoBehaviour
{
    public PlayerEncounterManager player;
    [HideInInspector]public int selfdifficulty;
    public bool biomdetected = false;
    public void Update()
    {
        print(selfdifficulty);
    }
    public void Start()
    {
        player = GameObject.Find("HitBox squirrel").GetComponent<PlayerEncounterManager>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "G.Biom")
        {
            selfdifficulty = 3;
            biomdetected = true;
        }
        if (other.gameObject.tag == "Gr.Biom")
        {
            selfdifficulty = 6;
            biomdetected = true;
        }
        if(other.gameObject.tag == "UnH.Biom")
        {
            selfdifficulty = 12;
            biomdetected = true;
        }
        if(other.gameObject.tag == "P.Biom")
        {
            selfdifficulty = 15;
            biomdetected = true;
        }
        if(other.gameObject.tag == "Squirrel Hitbox")
        {
            player.Updatestuff(selfdifficulty);
            Destroy(gameObject);
        }
    }
}
