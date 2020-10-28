using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public List<GameObject> zombie = new List<GameObject>();
    public static List<GameObject> zombieList = new List<GameObject>();
    public static GameObject zombieAddList;
    public static float SpawnZombieTime = 2f;
    int i;
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        if (i < 4)
        {
            yield return new WaitForSeconds(SpawnZombieTime);
            zombieAddList = Instantiate(zombie[Random.Range(0, zombie.Count)], new Vector3(Random.Range(4.5f, 7f), -2.22f, 33f), Quaternion.Euler(0, 180, 0));
            StartCoroutine(Spawn());
            zombieList.Add(zombieAddList);
            i++;
        }
    }
}
