using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TargetZombie : MonoBehaviour
{
    public static List<GameObject> bots = new List<GameObject>();
    float[] botsPosZ = new float[20];
    float backUp;
    GameObject backUpBot;
    void FixedUpdate()
    {
        bots = ZombieSpawner.zombieList;
       
        for (int i = 0; i < bots.Count; i++)
        {
            if(bots[i])
            {
                botsPosZ[i] = bots[i].transform.position.z;
            }
            else
            {
                bots[i].transform.DOKill();
            }
        }
        for (int i = 0; i < bots.Count; i++)
        {
            for (int j = i + 1; j < bots.Count; j++)
            {
                if (botsPosZ[j] < botsPosZ[i])
                {
                    backUp = botsPosZ[i];
                    backUpBot = bots[i];

                    botsPosZ[i] = botsPosZ[j];
                    bots[i] = bots[j];

                    botsPosZ[j] = backUp;
                    bots[j] = backUpBot;
                }
            }
        }
    }
}
