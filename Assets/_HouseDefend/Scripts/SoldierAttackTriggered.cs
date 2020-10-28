using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAttackTriggered : MonoBehaviour
{
    public List<SoldierAnimControler> SoldierAnimControler = new List<SoldierAnimControler>();

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Zombie")
        {
            for (int i = 0; i < SoldierAnimControler.Count; i++)
            {
                SoldierAnimControler[i].isThereZombie = true;
            }
        }
    }
}
