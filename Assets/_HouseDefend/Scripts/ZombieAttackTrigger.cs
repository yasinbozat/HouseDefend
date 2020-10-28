using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ZombieAttackTrigger : MonoBehaviour
{
    public HouseHealt houseHealt;  
    public SoldierAnimControler SoldierAnimControler;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zombie")
        {            
           other.gameObject.GetComponent<Animator>().SetInteger("Anim", -1);
           StartCoroutine(HouseDamage());
        }
    }
    IEnumerator HouseDamage()
    {
        if (SoldierAnimControler.isThereZombie)
        {
            yield return new WaitForSeconds(1);
            houseHealt.SetHouseDamage(ZombieMovement.damage);
            StartCoroutine(HouseDamage());
        }        
    }
}
