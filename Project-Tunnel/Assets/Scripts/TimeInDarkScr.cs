using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInDarkScr : MonoBehaviour
{

    public float totalTime;
    public GameObject scareObject;
    public Transform spawnPoint;
    public bool canSpawnStaticHaluc = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;

        if (totalTime > 30 && totalTime < 30.1)
        {
            canSpawnStaticHaluc = true;
        }
        SpawnAspect();
    }

    void SpawnAspect()
    {
        if (canSpawn)
        {
            GameObject scareInstance = Instantiate(scareObject, spawnPoint.position, spawnPoint.rotation);
            canSpawn = false;
        }
    }
}
