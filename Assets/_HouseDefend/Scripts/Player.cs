using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int gold;

    public void GetGold(int zombieGold)
    {
        zombieGold = gold;
    }
    public void SetGold(int zombieGold)
    {
        gold += zombieGold;
    }


}
