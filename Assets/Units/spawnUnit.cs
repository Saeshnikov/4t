using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnUnit : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject enemySpawnPoint;
    public GameObject objToSpawn;
    public float _movingSpeed;
    // Start is called before the first frame update
    public void spawn()
    {
        Instantiate(objToSpawn, spawnPoint.transform.position, Quaternion.identity);
        Debug.Log("Spawned new object.");
    }
}
