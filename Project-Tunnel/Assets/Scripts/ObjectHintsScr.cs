using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHintsScr : MonoBehaviour
{

    public GameObject rustyHint;
    public GameObject crateCrowbar;
    public GameObject allenKey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
