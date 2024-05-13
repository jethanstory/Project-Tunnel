using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupOtherGoalItemsScr : MonoBehaviour
{

    bool canpickup; //a bool to see if you can or cant pick up the item
    GameObject ObjectIwantToDestroy; // the gameobject onwhich you collided with

    public GameObject keySound;

    public bool rustyKnifePickup;
    public bool crateCrowbarPickup;
    public bool allenKeyPickup;

    public bool flimsySawPickup;

    public bool oldCam;

    public GameObject rustyKnifePickupNotification;

    public GameObject crateCrowbarPickupNotification;

    public GameObject allenKeyPickupNotification;
    public GameObject flimsySawPickupNotification;

    public GameObject rustyKnifePickupNotificationOldCam;

    public GameObject crateCrowbarPickupNotificationOldCam;

    public GameObject allenKeyPickupNotificationOldCam;

    public GameObject flimsySawPickupNotificationOldCam;

    public float secondsCount = 0;

    bool rustyShown;
    bool allenShown;

    bool sawShown;

    bool crowbarShown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rustyKnifePickup && !rustyShown)
        {
            secondsCount += Time.deltaTime;
            rustyKnifePickupNotification.SetActive(true);

            if (secondsCount > 2)
            {
                rustyKnifePickupNotification.SetActive(false);
                rustyShown = true;

                //endTime = true;
                //secondsCount = 100;
                // textGoal.SetActive(true);
                // if (secondsCount > 10)
                // {
                //     textGoal.SetActive(false);
                // }
            }
        }

        if (crateCrowbarPickup && !crowbarShown)
        {
            secondsCount += Time.deltaTime;
            crateCrowbarPickupNotification.SetActive(true);

            if (secondsCount > 2)
            {
                crateCrowbarPickupNotification.SetActive(false);
                crowbarShown = true;
                //endTime = true;
                //secondsCount = 100;
                // textGoal.SetActive(true);
                // if (secondsCount > 10)
                // {
                //     textGoal.SetActive(false);
                // }
            }
        }
        if (allenKeyPickup && !allenShown)
        {
            secondsCount += Time.deltaTime;
            allenKeyPickupNotification.SetActive(true);

            if (secondsCount > 2)
            {
                allenKeyPickupNotification.SetActive(false);
                allenShown = true;
                //endTime = true;
                //secondsCount = 100;
                // textGoal.SetActive(true);
                // if (secondsCount > 10)
                // {
                //     textGoal.SetActive(false);
                // }
            }
        }

        if (flimsySawPickup && !sawShown)
        {
            secondsCount += Time.deltaTime;
            flimsySawPickupNotification.SetActive(true);

            if (secondsCount > 2)
            {
                flimsySawPickupNotification.SetActive(false);
                sawShown = true;
                //endTime = true;
                //secondsCount = 100;
                // textGoal.SetActive(true);
                // if (secondsCount > 10)
                // {
                //     textGoal.SetActive(false);
                // }
            }
        }
    }

    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if (other.gameObject.tag == "AllenKeyPickup") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            secondsCount = 0;
            // canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            allenKeyPickup = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
        }

        if (other.gameObject.tag == "RustyKnifePickup") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            secondsCount = 0;
            // canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            rustyKnifePickup = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
        }
        if (other.gameObject.tag == "CrowbarPickup") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            secondsCount = 0;
            // canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            crateCrowbarPickup = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
        }
        if (other.gameObject.tag == "FlimsySawPickup") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            secondsCount = 0;
            // canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            flimsySawPickup = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // canpickup = false; //when you leave the collider set the canpickup bool to false

    }
}
