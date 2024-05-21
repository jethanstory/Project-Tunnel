using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuddenMannTriggerScr : MonoBehaviour
{
    public GameObject mann;

    bool isTriggered;

    float secondsCount = 0f;

    public GameObject Sound;
    public GameObject startSound;
    public GameObject startFlicker;
    public GameObject normalLight;
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
        secondsCount = 0;
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
            startSound.SetActive(true);
            //SceneManager.LoadScene(2);
            Debug.Log("HIT");

            isTriggered = true;
            // startFlicker.SetActive(true);
            normalLight.SetActive(false);
            GameObject.Find("Camera_adv").GetComponent<FlickeringLight>().enabled = true;
            // ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            // Destroy(ObjectIwantToDestroy);

            // mann.SetActive(true);


        }

    }


    // Update is called once per frame
    void Update()
    {
        if (isTriggered)
        {
            secondsCount += Time.deltaTime;
            if (secondsCount > 5)
            {
                // startFlicker.SetActive(false);
                mann.SetActive(false);
                normalLight.SetActive(true);
                GameObject.Find("Camera_adv").GetComponent<FlickeringLight>().enabled = false;
                if (secondsCount > 6)
                    startFlicker.SetActive(false);

            }

        }
    }
}
