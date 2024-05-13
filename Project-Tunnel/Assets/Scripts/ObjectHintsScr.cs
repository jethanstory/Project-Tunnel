using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHintsScr : MonoBehaviour
{

    public GameObject rustyHint;
    public GameObject rustyHintOld;
    public GameObject crateCrowbar;
    public GameObject crateCrowbarOld;
    public GameObject allenKey;
    public GameObject allenKeyOld;
    public GameObject flimsySaw;
    public GameObject flimsySawOld;

    bool inCrateArea;
    bool inLockerArea;
    bool inSawDoorArea;
    bool inAllenGrateArea;

    public bool crowbarCheck;
    public bool knifeCheck;
    public bool sawCheck;
    public bool allenCheck;

    public GameObject animatedCrowbar;



    // public AnimationClip pry;
    // public AnimationClip open;
    // public Animation animCrow;
    // public Animation animLid;

    public GameObject animatedLid;
    public GameObject origCrate;
    public GameObject origLocker;
    public GameObject origOfficeDoor;
    public GameObject origGrate;
    public GameObject animatedGrate;
    public GameObject animatedAllen;
    public GameObject animatedOfficeDoor;
    public GameObject animatedCrate;
    public GameObject animatedKnife;
    public GameObject animatedLocker;
    public GameObject animatedSaw;

    public GameObject actualLockerCrowbar;

    public GameObject actualFlimsySaw;

    public float secondsCount = 0f;

    public GameObject fpsPlayer;
    public GameObject rootObject;

    bool sawHasPlayed;
    bool crowHasPlayed;
    bool knifeHasPlayed;
    bool AllenHasPlayed;


    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animation>();
        // animCrow = animatedCrowbar.GetComponent<Animation>();
        // animLid = animatedLid.GetComponent<Animation>();
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

        if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().flimsySawPickup)
        {
            sawCheck = true;
        }

        if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().allenKeyPickup)
        {
            allenCheck = true;
        }

        if (inCrateArea)
        {
            // Debug.Log("This shit works");
            if (crowbarCheck && !crowHasPlayed)
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
                    crowHasPlayed = true;
                    // sawPickup.SetActive(true);
                }


                // animatedCrowbar.SetActive(false);

            }
            else if (!crowHasPlayed)
            {
                if (rootObject.GetComponent<BatteryIconScr>().bigSwap)
                {
                    crateCrowbarOld.SetActive(true);
                }
                crateCrowbar.SetActive(true);
            }
        }


        if (inLockerArea)
        {
            // Debug.Log("This shit works");
            if (knifeCheck && !knifeHasPlayed)
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
                    knifeHasPlayed = true;
                }

            }
            else if (!knifeHasPlayed)
            {
                if (rootObject.GetComponent<BatteryIconScr>().bigSwap)
                {
                    rustyHintOld.SetActive(true);
                }
                rustyHint.SetActive(true);
            }
        }

        if (inSawDoorArea && !sawHasPlayed)
        {
            // Debug.Log("This shit works");
            if (sawCheck)
            {
                secondsCount += Time.deltaTime;
                animatedSaw.SetActive(true);
                if (secondsCount > 1.8)
                {
                    origOfficeDoor.SetActive(false);
                    animatedOfficeDoor.SetActive(true);
                    // animLid.clip = open;
                    // animLid.Play();
                }

                if (secondsCount > 2.6)
                {
                    //animatedCrate.SetActive(false);
                    animatedSaw.SetActive(false);
                    sawCheck = false;
                    sawHasPlayed = true;
                }

            }
            else if (!sawHasPlayed)
            {
                if (rootObject.GetComponent<BatteryIconScr>().bigSwap)
                {
                    flimsySawOld.SetActive(true);
                }
                flimsySaw.SetActive(true);
            }
        }

        if (inAllenGrateArea && !AllenHasPlayed)
        {
            // Debug.Log("This shit works");
            if (allenCheck)
            {
                secondsCount += Time.deltaTime;
                animatedAllen.SetActive(true);
                if (secondsCount > 15)
                {
                    origGrate.SetActive(false);
                    animatedGrate.SetActive(true);
                    // animLid.clip = open;
                    // animLid.Play();
                }

                if (secondsCount > 16)
                {
                    //animatedCrate.SetActive(false);
                    animatedAllen.SetActive(false);
                    allenCheck = false;
                    AllenHasPlayed = true;
                }

            }
            else if (!AllenHasPlayed)
            {
                if (rootObject.GetComponent<BatteryIconScr>().bigSwap)
                {
                    allenKeyOld.SetActive(true);
                }
                allenKey.SetActive(true);
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
        if (other.gameObject.tag == "AllenKeyGrateHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            inAllenGrateArea = true;
            secondsCount = 0;
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
        flimsySaw.SetActive(false);
        inLockerArea = false;
        inCrateArea = false;
        inSawDoorArea = false;
        inAllenGrateArea = false;
        crateCrowbarOld.SetActive(false);
        allenKeyOld.SetActive(false);
        allenKeyOld.SetActive(false);
        flimsySawOld.SetActive(false);

        // sawPickup.SetActive(false);

    }
}
