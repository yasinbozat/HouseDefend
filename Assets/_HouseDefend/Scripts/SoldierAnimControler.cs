using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SoldierAnimControler : MonoBehaviour
{
    public Actions actions;
    public bool isThereZombie = false;
    public GameObject bullet;
    GameObject bullet2;
    public static float Damage = 0.05f;
    public static float SoldierFireTime = 1f;
    int target;
    // Start is called before the first frame update
    void Start()
    {
        actions.Aiming();
        InvokeRepeating("IsThereZombie",0, SoldierFireTime);
    }
    public void IsThereZombie()
    {
        if(isThereZombie)
        {
            actions.Attack();            
            gameObject.transform.LookAt(TargetZombie.bots[target].transform);
            DamageToZombie(Damage);
            BulletSpawn();
            if (TargetZombie.bots[target].GetComponentInChildren<ZombieHealthBar>().transform.localScale.z<=0)
            {
                TargetZombie.bots[target].SetActive(false);
                target++;                
            }
            isThereZombie = false;
        }
    }
    public void DamageToZombie(float damage)
    {
        TargetZombie.bots[target].GetComponentInChildren<ZombieHealthBar>().transform.localScale -= new Vector3(0, 0, damage);
    }
    public void BulletSpawn()
    {
        bullet2 = Instantiate(bullet,new Vector3(transform.position.x, transform.position.y + 0.70f, transform.position.z), Quaternion.Euler(90,0,0));
        bullet2.transform.DOMoveX(TargetZombie.bots[target].transform.position.x, 0.5f);
        bullet2.transform.DOMoveZ(TargetZombie.bots[target].transform.position.z, 0.5f);
    }
}
