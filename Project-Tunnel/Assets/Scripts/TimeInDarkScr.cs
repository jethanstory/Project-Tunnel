using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInDarkScr : MonoBehaviour
{

    public float totalTime;
    public GameObject scareObject;
    public Transform spawnPoint;
    public bool canSpawnStaticHaluc = false;
    public bool canSpawnMovingHaluc = false;

    public GameObject staticSpawnAll;
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
        SpawnAspectStatic();
    }

    void SpawnAspectStatic()
    {
        if (canSpawnStaticHaluc)
        {
            // GameObject scareInstance = Instantiate(scareObject, spawnPoint.position, spawnPoint.rotation);
            staticSpawnAll.SetActive(true);
            canSpawnStaticHaluc = false;
        }

        if (canSpawnMovingHaluc)
        {
            GameObject scareInstance = Instantiate(scareObject, spawnPoint.position, spawnPoint.rotation);
            canSpawnMovingHaluc = false;
        }
    }
}
