using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ZombieAttackTrigger : MonoBehaviour
{
    public SoldierAnimControler SoldierAnimControler;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zombie")
        {
            other.gameObject.GetComponent<Animator>().SetInteger("Anim", -1);
            // 
        }
    }
}
