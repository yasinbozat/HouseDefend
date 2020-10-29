using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ZombieMovement : MonoBehaviour
{
    public int speed = 30;
    void Start()
    {
        transform.DOLocalMoveZ(20, speed);
    }
}
