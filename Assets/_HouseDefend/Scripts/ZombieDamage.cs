using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ZombieDamage : MonoBehaviour
{
    public float CoolDown;
    public GameObject HouseHealt;
    public int AttackDamage;
    float setDamage;
    public Text hpText;
    private void Start()
    {
        HouseHealt = GameObject.Find("Health");
        //Time.timeScale = 3F;
        //setDamage = (float)AttackDamage / 100;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="ZombieAttackTrigger")
        {           
            StartCoroutine(DamageLoop());
        }
    }
    IEnumerator DamageLoop()
    {        
        yield return new WaitForSeconds(CoolDown);
        HouseHealt.GetComponent<HouseHealt>().SetHouseDamage(AttackDamage);
        StartCoroutine(DamageLoop());        
    }
}
