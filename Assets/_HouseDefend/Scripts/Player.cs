using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int gold;

    public Text goldText;

    public void GetGold(int zombieGold)
    {
        zombieGold = gold;
    }
    public void SetGold(int zombieGold)
    {
        gold += zombieGold;
        goldText.text = gold.ToString();
    }




}
