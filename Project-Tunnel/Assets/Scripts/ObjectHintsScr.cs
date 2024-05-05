using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHintsScr : MonoBehaviour
{

    public GameObject rustyHint;
    public GameObject crateCrowbar;
    public GameObject allenKey;

    bool inCrateArea;

    bool inLockerArea;

    public bool crowbarCheck = true;

    public bool knifeCheck = true;

    public GameObject animatedCrowbar;



    public AnimationClip pry;
    public AnimationClip open;
    public Animation animCrow;
    public Animation animLid;

    public GameObject animatedLid;
    public GameObject origCrate;

    public GameObject origLocker;
    public GameObject animatedCrate;

    public GameObject animatedKnife;

    public GameObject animatedLocker;

    public GameObject actualLockerCrowbar;

    public float secondsCount = 0f;


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
                    //animatedCrate.SetActive(false);
                    animatedCrowbar.SetActive(false);
                }


                // animatedCrowbar.SetActive(false);

            }
            else
            {
                crateCrowbar.SetActive(true);
                secondsCount = 0;
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
                }

            }
            else
            {
                rustyHint.SetActive(true);
                secondsCount = 0;
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
            secondsCount = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        rustyHint.SetActive(false);
        crateCrowbar.SetActive(false);
        allenKey.SetActive(false);
    }
}
