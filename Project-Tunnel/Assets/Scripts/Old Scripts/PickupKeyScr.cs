using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKeyScr : MonoBehaviour
{
    bool canpickup; //a bool to see if you can or cant pick up the item
    GameObject ObjectIwantToDestroy; // the gameobject onwhich you collided with

    public GameObject keySound;

    public GameObject stationKeySmallDoorPickupHint;

    public int keysCollected;
    public int maxKeys;

    public bool firstKeyCollected;
    public bool secondKeyCollected;



    public bool canUnlock;
    public bool smallStationKeyCollected;
    public bool storageKeyCollected;
    public bool inSmallStationDoorArea;
    public bool stationDoorHasPlayed;


    public GameObject animatedStationDoor;
    public GameObject origStationDoor;

    float secondsCount;

    public GameObject doorLockedSound;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (smallStationKeyCollected)
        {
            secondsCount += Time.deltaTime;
            stationKeySmallDoorPickupHint.SetActive(true);

            if (secondsCount > 2)
            {
                stationKeySmallDoorPickupHint.SetActive(false);
            }
        }

        if (inSmallStationDoorArea)
        {
            // Debug.Log("This shit works");
            if (smallStationKeyCollected && !stationDoorHasPlayed)
            {
                secondsCount += Time.deltaTime;
                origStationDoor.SetActive(false);
                animatedStationDoor.SetActive(true);

                // animCrow.clip = pry;
                // animCrow.Play();

                if (secondsCount > 1)
                {

                    // animatedCrate.SetActive(true);
                    //smallStationKeyCollected = false;
                    stationDoorHasPlayed = true;
                    // animLid.clip = open;
                    // animLid.Play();
                }

                // if (secondsCount > 2.6)
                // {

                //     actualFlimsySaw.SetActive(true);
                //     //animatedCrate.SetActive(false);
                //     animatedCrowbar.SetActive(false);
                //     crowbarCheck = false;
                //     crowHasPlayed = true;
                //     // sawPickup.SetActive(true);
                // }


                // animatedCrowbar.SetActive(false);

            }
            else if (!stationDoorHasPlayed)
            {
                doorLockedSound.SetActive(false);
                doorLockedSound.SetActive(true);
            }
        }

        // if (canpickup == true) // if you enter thecollider of the objecct
        // {


        // }
        if (keysCollected >= maxKeys)
        {
            canUnlock = true;
        }

    }

    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if (other.gameObject.tag == "OfficeKeyPickup") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            // canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            keysCollected += 1;
            smallStationKeyCollected = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
        }

        if (other.gameObject.tag == "StorageKey") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            // canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            keysCollected += 1;
            storageKeyCollected = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
        }
        if (other.gameObject.tag == "SmallStationDoorHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            inSmallStationDoorArea = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // canpickup = false; //when you leave the collider set the canpickup bool to false
    }

}
