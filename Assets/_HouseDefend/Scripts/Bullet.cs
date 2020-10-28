using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject zombie;
    public Animation ZombieBloodAnim;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Zombie")
        {
            zombie = other.gameObject;
            Destroy(gameObject);
            //blood effect
        }        
    }
}
