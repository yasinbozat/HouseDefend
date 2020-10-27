using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseHealt : MonoBehaviour
{
    public GameObject houseHealthBar;
    public float health = 1f; 
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 3;
        //InvokeRepeating("houseHealthBar",0,0.5f);  
    }
    public void HouseHealthBar()
    {

    }
    public void GetHouseDamage(float Damage)
    {
        transform.localScale -= new Vector3(0, 0, Damage);
    }

}
