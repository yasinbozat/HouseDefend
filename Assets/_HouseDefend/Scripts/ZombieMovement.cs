using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ZombieMovement : MonoBehaviour
{   public int speed=30;
    public float damage=0.1f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        transform.DOLocalMoveZ(20, speed);
    }
}
