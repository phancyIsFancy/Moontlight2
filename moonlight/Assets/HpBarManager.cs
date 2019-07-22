using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarManager : MonoBehaviour
{
    public int amounttospawnhp;
    public BattleManager battle;
    public Image bar;
    public Image barfilled;
    private void Start()
    {
        battle = GameObject.Find("EventSystem ").GetComponent<BattleManager>();
    }
    public void Recreate(int amounttomake)
    {
        Instantiate(gameObject, transform.position, Quaternion.identity, FindObjectOfType<Canvas>().transform);
    }
    public void Update()
    {
        if (barfilled.fillAmount <= 0)
        {
            battle.hpbar -= 1;
            Destroy(gameObject);
        }
        if(battle.hpbar > 0)
        {
            Recreate(battle.hpbar);
        }
    }

}
