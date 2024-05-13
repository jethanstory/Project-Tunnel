using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInDarkScr : MonoBehaviour
{

    public float totalTime;
    public int soundTime = 1;
    public GameObject scareObject;
    public Transform spawnPoint;
    public bool canSpawnStaticHaluc = false;
    public bool canSpawnMovingHaluc = false;

    public bool canSuddenSound = false;

    public GameObject staticSpawnAll;
    public GameObject movingSpawnAll;
    public GameObject suddenMetalDrop;
    public GameObject distantMetalScrape;
    public GameObject noisyMetal;

    public GameObject advancedNoise;
    public GameObject originalHallNoise;
    public GameObject fpsPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (fpsPlayer.GetComponent<FilmPercentageScr>().filmPercentageCount > 30)
        {
            advancedNoise.SetActive(true);
            originalHallNoise.SetActive(false);
        }

        totalTime += Time.deltaTime;
        soundTime++;

        if (totalTime > 360 && totalTime < 30.1)
        {
            canSpawnStaticHaluc = true;
        }
        if (totalTime > 480)
        {
            canSpawnMovingHaluc = true;
        }

        if (soundTime % 1000 == 0)
        {
            canSuddenSound = true;
        }
        // if (soundTime % 100 == 0)
        // {
        // if (totalTime % 100 == 0)
        // {
        if (totalTime > 100)
        {

        }
        SpawnAspect();
        SoundAspect();
    }

    void SpawnAspect()
    {
        if (canSpawnStaticHaluc)
        {
            // GameObject scareInstance = Instantiate(scareObject, spawnPoint.position, spawnPoint.rotation);
            staticSpawnAll.SetActive(true);
            canSpawnStaticHaluc = false;
        }

        if (canSpawnMovingHaluc)
        {
            // GameObject scareInstance = Instantiate(scareObject, spawnPoint.position, spawnPoint.rotation);
            movingSpawnAll.SetActive(true);
            canSpawnMovingHaluc = false;
        }
    }
    void SoundAspect()
    {
        if (canSuddenSound)
        {
            int soundSelection = Random.Range(1, 3);

            if (soundSelection == 1)
            {
                suddenMetalDrop.SetActive(false);
                suddenMetalDrop.SetActive(true);
                canSuddenSound = false;
            }
            if (soundSelection == 2)
            {
                distantMetalScrape.SetActive(false);
                distantMetalScrape.SetActive(true);
                canSuddenSound = false;
            }
            if (soundSelection == 3)
            {
                noisyMetal.SetActive(false);
                noisyMetal.SetActive(true);
                canSuddenSound = false;
            }
        }
    }
}
