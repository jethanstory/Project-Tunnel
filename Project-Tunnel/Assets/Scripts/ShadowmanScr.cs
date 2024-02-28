using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowmanScr : MonoBehaviour
{
    GameObject ObjectIwantToDestroy;

    public GameObject shadow;
    // Start is called before the first frame update
    // void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    // {
    //     if (collisionInfo.collider.name == "Shadowman")

    //     {

    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if (other.gameObject.tag == "Shadowman") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            Cursor.lockState = CursorLockMode.None;
            //SceneManager.LoadScene(2);
            Debug.Log("HIT");
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            shadow.SetActive(false);


        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
