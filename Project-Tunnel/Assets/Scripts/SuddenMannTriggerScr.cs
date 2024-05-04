using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuddenMannTriggerScr : MonoBehaviour
{
    public GameObject mann;

    public GameObject Sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        // if (other.gameObject.tag == "MannequinTest") //on the object you want to pick up set the tag to be anything, in this case "object"
        // {
        //     Cursor.lockState = CursorLockMode.None;
        //     //SceneManager.LoadScene(2);
        //     Debug.Log("HIT");
        //     // ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
        //     // Destroy(ObjectIwantToDestroy);
        //     mann.SetActive(false);


        // }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "HeadScare") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            // GameObject.Find("headMove").GetComponent<FollowingEnemy>().enabled = true;

            GameObject.Find("mannequin_03_test_SuddenMove").GetComponent<FollowingEnemy>().enabled = true;
            GameObject.Find("headMoveSudden").GetComponent<RotateLightScr>().enabled = true;
            Cursor.lockState = CursorLockMode.None;

            Sound.SetActive(true);
            //SceneManager.LoadScene(2);
            Debug.Log("HIT");
            // ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            // Destroy(ObjectIwantToDestroy);

            // mann.SetActive(true);


        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
