using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePreferences : MonoBehaviour
{
    public int zombieGold;
    public GameObject player;


    private void Start()
    {
        player = GameObject.Find("Player");

    }
    public void FixedUpdate()
    {
        if (GetComponentInChildren<ZombieHealthBar>().transform.localScale.z <= 0)
        {
            gameObject.SetActive(false);
            player.GetComponent<Player>().SetGold(zombieGold);


        }
    }

}
