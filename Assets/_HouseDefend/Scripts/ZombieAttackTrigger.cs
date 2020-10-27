using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttackTrigger : MonoBehaviour
{
    public HouseHealt houseHealt;
    public ZombieMovement ZombieMovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zombie")
        {            
           other.gameObject.GetComponent<Animator>().SetInteger("Anim", -1);
           houseHealt.GetHouseDamage(ZombieMovement.damage);
        }        
    } 
}
