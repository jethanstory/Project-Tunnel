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

    public bool oldCam;

    public GameObject rustyKnifePickupNotification;

    public GameObject crateCrowbarPickupNotification;

    public GameObject allenKeyPickupNotification;

    public GameObject rustyKnifePickupNotificationOldCam;

    public GameObject crateCrowbarPickupNotificationOldCam;

    public GameObject allenKeyPickupNotificationOldCam;

    public float secondsCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rustyKnifePickup)
        {
            secondsCount += Time.deltaTime;
            rustyKnifePickupNotification.SetActive(true);

            if (secondsCount > 2) 
            {
                rustyKnifePickupNotification.SetActive(false);
                //endTime = true;
                //secondsCount = 100;
                // textGoal.SetActive(true);
                // if (secondsCount > 10)
                // {
                //     textGoal.SetActive(false);
                // }
            }
        }

        if (crateCrowbarPickup)
        {
            secondsCount += Time.deltaTime;
            crateCrowbarPickupNotification.SetActive(true);

            if (secondsCount > 2) 
            {
                crateCrowbarPickupNotification.SetActive(false);
                //endTime = true;
                //secondsCount = 100;
                // textGoal.SetActive(true);
                // if (secondsCount > 10)
                // {
                //     textGoal.SetActive(false);
                // }
            }
        }
        if (allenKeyPickup)
        {
            secondsCount += Time.deltaTime;
            allenKeyPickupNotification.SetActive(true);

            if (secondsCount > 2) 
            {
                allenKeyPickupNotification.SetActive(false);
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
        if(other.gameObject.tag == "AllenKeyPickup") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            secondsCount = 0;
            canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            allenKeyPickup = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
            rustyKnifePickupNotification.SetActive(true);
        }
        
        if(other.gameObject.tag == "RustyKnifePickup") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            secondsCount = 0;
            canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            rustyKnifePickup = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
        }
        if(other.gameObject.tag == "CrateCrowbarPickup") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            secondsCount = 0;
            canpickup = true;  //set the pick up bool to true
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            crateCrowbarPickup = true;
            keySound.SetActive(false);
            keySound.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        canpickup = false; //when you leave the collider set the canpickup bool to false
     
    }
}
