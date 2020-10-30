using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseLevel : MonoBehaviour
{
    public List<GameObject> HouseLvl = new List<GameObject>();
    int counter;

    public void HouseLvlUp()
    {       
        if (counter < HouseLvl.Count-1)
        {
            HouseLvl[counter].SetActive(false);
            counter++;
            HouseLvl[counter].SetActive(true);
        }
    }
}
