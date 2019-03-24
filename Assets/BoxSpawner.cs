using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{

    ObjectPooler boxPooler;

    // Start is called before the first frame update
    void Start()
    {
        boxPooler = ObjectPooler.Instance;
        InvokeRepeating("SpawnBox", 0f, 1f);
    }

    void SpawnBox()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(7f, 8f));
        Quaternion spawnRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
        boxPooler.SpawnFromPool("box", spawnPosition, spawnRotation);
    }
}
