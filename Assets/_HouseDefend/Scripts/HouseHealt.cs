using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseHealt : MonoBehaviour
{
    public float healthPoint;
    public float currentHealthPoint,hp;
    private void Start()
    {
        currentHealthPoint = healthPoint;
        Time.timeScale = 3f;
        hp = currentHealthPoint / healthPoint;
        transform.localScale = new Vector3(1, 1, hp);
    }
    public void SetHouseDamage(float Damage)
    {
        currentHealthPoint -= Damage;
        hp = currentHealthPoint / healthPoint;
        transform.localScale = new Vector3(1, 1, hp);
    }
    public void GetHouseHealth(float Health)
    {
        currentHealthPoint += Health;
        hp = currentHealthPoint / healthPoint;
        transform.localScale = new Vector3(1, 1, hp);
    }
}
