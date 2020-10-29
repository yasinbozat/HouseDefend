using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Animation ZombieBloodAnim;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Zombie")
        {
            Destroy(gameObject);
            //blood effect
        }        
    }
}
