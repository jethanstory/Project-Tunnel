using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHintsScr : MonoBehaviour
{

    public GameObject rustyHint;
    public GameObject crateCrowbar;
    public GameObject allenKey;

    bool inCrateArea;

    public bool crowbarCheck = true;

    public GameObject animatedCrowbar;

    

    public AnimationClip pry;
    public AnimationClip open;
    public Animation animCrow;
    public Animation animLid;

    public GameObject animatedLid;
    public GameObject origCrate;
    public GameObject animatedCrate;


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
                origCrate.SetActive(false);
                animatedCrate.SetActive(true);
                animatedCrowbar.SetActive(true);
                animCrow.clip = pry;
                animCrow.Play();
                animLid.clip = open;
                animLid.Play();

                // animatedCrowbar.SetActive(false);

            }
        }
    }


    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if(other.gameObject.tag == "RustyKnifeHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            rustyHint.SetActive(true);
        }
        
        if(other.gameObject.tag == "CrateCrowbarHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            crateCrowbar.SetActive(true);
            inCrateArea = true;

        }
        if(other.gameObject.tag == "allenKeyHint") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            allenKey.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {   
        rustyHint.SetActive(false);
        crateCrowbar.SetActive(false);
        allenKey.SetActive(false);
    }
}
