using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilmPercentageScr : MonoBehaviour
{
    bool canpickup; //a bool to see if you can or cant pick up the item
    GameObject ObjectIwantToDestroy; // the gameobject onwhich you collided with

    public int filmPercentageCount;

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
        if (other.gameObject.tag == "FilmTrig") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            filmPercentageCount+=2;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
    }

}
