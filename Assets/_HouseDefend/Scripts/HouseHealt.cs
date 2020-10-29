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

    

    private void Start()
    {
        currentHealthPoint = healthPoint;
        Time.timeScale = 3f;
        hp = currentHealthPoint / healthPoint;
        transform.localScale = new Vector3(1, 1, hp);
        hpText.text = currentHealthPoint.ToString();

    }
    public void SetHouseDamage(float Damage)
    {
        currentHealthPoint -= Damage;
        hp = currentHealthPoint / healthPoint;
        transform.localScale = new Vector3(1, 1, hp);
        hpText.text = currentHealthPoint.ToString();

    }
    public void GetHouseHealth(float Health)
    {
        currentHealthPoint += Health;
        hp = currentHealthPoint / healthPoint;
        transform.localScale = new Vector3(1, 1, hp);
        hpText.text = currentHealthPoint.ToString();

    }
}
