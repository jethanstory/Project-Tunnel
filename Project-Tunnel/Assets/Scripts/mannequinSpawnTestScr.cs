using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mannequinSpawnTestScr : MonoBehaviour
{
    public GameObject mann;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if (other.gameObject.tag == "MannequinTest") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            Cursor.lockState = CursorLockMode.None;
            //SceneManager.LoadScene(2);
            Debug.Log("HIT");
            // ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            // Destroy(ObjectIwantToDestroy);
            mann.SetActive(false);


        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
