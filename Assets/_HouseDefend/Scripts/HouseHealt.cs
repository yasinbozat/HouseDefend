using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseHealt : MonoBehaviour
{
    public GameObject houseHealthBar;
    public void SetHouseDamage(float Damage)
    {
        transform.localScale -= new Vector3(0, 0, Damage);
    }
    public void GetHouseHealt(float Healt)
    {
        transform.localScale += new Vector3(0, 0, Healt);
    }
}
