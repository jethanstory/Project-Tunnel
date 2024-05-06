using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHintsScr : MonoBehaviour
{

    public GameObject rustyHint;
    public GameObject crateCrowbar;
    public GameObject allenKey;

    public GameObject flimsySaw;

    bool inCrateArea;

    bool inLockerArea;

    bool inSawDoorArea;

    public bool crowbarCheck;

    public bool knifeCheck;

    public bool sawCheck;

    public GameObject animatedCrowbar;



    // public AnimationClip pry;
    // public AnimationClip open;
    // public Animation animCrow;
    // public Animation animLid;

    public GameObject animatedLid;
    public GameObject origCrate;

    public GameObject origLocker;
    public GameObject animatedCrate;

    public GameObject animatedKnife;

    public GameObject animatedLocker;

    public GameObject animatedSaw;

    public GameObject actualLockerCrowbar;

    public GameObject actualFlimsySaw;

    public float secondsCount = 0f;

    public GameObject fpsPlayer;


    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animation>();
        animCrow = animatedCrowbar.GetComponent<Animation>();
        animLid = animatedLid.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

        if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().rustyKnifePickup)
        {
            knifeCheck = true;
        }

        if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().crateCrowbarPickup)
        {
            crowbarCheck = true;
        }

        if (inCrateArea)
        {
            // Debug.Log("This shit works");
            if (crowbarCheck)
            {
                secondsCount += Time.deltaTime;
                animatedCrowbar.SetActive(true);
                // animCrow.clip = pry;
                // animCrow.Play();

                if (secondsCount > 1)
                {
                    origCrate.SetActive(false);
                    animatedCrate.SetActive(true);
                    // animLid.clip = open;
                    // animLid.Play();
                }

                if (secondsCount > 2.6)
                {

                    actualFlimsySaw.SetActive(true);
                    //animatedCrate.SetActive(false);
                    animatedCrowbar.SetActive(false);
                    crowbarCheck = false;
                    // sawPickup.SetActive(true);
                }


                // animatedCrowbar.SetActive(false);

            }
            else
            {
                crateCrowbar.SetActive(true);
            }
        }


        if (inLockerArea)
        {
            // Debug.Log("This shit works");
            if (knifeCheck)
            {
                secondsCount += Time.deltaTime;
                animatedKnife.SetActive(true);
                if (secondsCount > 1)
                {
                    actualLockerCrowbar.SetActive(true);
                    origLocker.SetActive(false);
                    animatedLocker.SetActive(true);
                    // animLid.clip = open;
                    // animLid.Play();
                }

                if (secondsCount > 2.6)
                {
                    //animatedCrate.SetActive(false);
                    animatedKnife.SetActive(false);
                    knifeCheck = false;
                }

            }
            else
            {
                rustyHint.SetActive(true);
            }
        }

        if (inSawDoorArea)
        {
            // Debug.Log("This shit works");
            if (sawCheck)
            {
                secondsCount += Time.deltaTime;
                animatedKnife.SetActive(true);
                if (secondsCount > 1)
                {
                    actualLockerCrowbar.SetActive(true);
                    origLocker.SetActive(false);
                    animatedLocker.SetActive(true);
                    // animLid.clip = open;
                    // animLid.Play();
                }

                if (secondsCount > 2.6)
                {
                    //animatedCrate.SetActive(false);
                    animatedKnife.SetActive(false);
                    knifeCheck = false;
                }

            }
            else
            {
                rustyHint.SetActive(true);
            }
        }
    }


    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if (other.gameObject.tag == "RustyKnifeHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            inLockerArea = true;
            secondsCount = 0;
        }

        if (other.gameObject.tag == "CrateCrowbarHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {

            inCrateArea = true;
            secondsCount = 0;

        }
        if (other.gameObject.tag == "allenKeyHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            allenKey.SetActive(true);
        }
        if (other.gameObject.tag == "SawDoorHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            inSawDoorArea = true;
            secondsCount = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        rustyHint.SetActive(false);
        crateCrowbar.SetActive(false);
        allenKey.SetActive(false);
        inLockerArea = false;
        inCrateArea = false;
        // sawPickup.SetActive(false);

    }
}
