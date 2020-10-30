using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class HouseHealt : MonoBehaviour
{
    public float healthPoint;
    public float currentHealthPoint,hp;
    public Text hpText;
    public Boolean isItEnd = false;
    private void Start()
    {
        Time.timeScale = 3f;
        currentHealthPoint = healthPoint;
        hp = currentHealthPoint / healthPoint;
        transform.localScale = new Vector3(1, 1, hp);
        hpText.text = currentHealthPoint.ToString();
    }
    public void SetHouseDamage(float Damage)
    {
        if (currentHealthPoint <= 0)
        {
            isItEnd = true;
        }

        if (currentHealthPoint > 0)
        {
            currentHealthPoint -= Damage;
            hp = currentHealthPoint / healthPoint;
            transform.localScale = new Vector3(1, 1, hp);
            hpText.text = currentHealthPoint.ToString();
        }
        else
        {
            hp = 0;
        }
    }
    public void GetHouseHealth(float Health)
    {
        currentHealthPoint += Health;
        hp = currentHealthPoint / healthPoint;
        transform.localScale = new Vector3(1, 1, hp);
        hpText.text = currentHealthPoint.ToString();
    }
}
