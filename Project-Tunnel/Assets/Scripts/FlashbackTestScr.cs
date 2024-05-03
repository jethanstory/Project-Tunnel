using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashbackTestScr : MonoBehaviour
{
    public GameObject ev;
    public GameObject origin;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if (other.gameObject.tag == "FlashbackTest") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("HIT");
            ev.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "FlashbackTest") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            Cursor.lockState = CursorLockMode.None;
            ev.SetActive(false);
            origin.SetActive(false);
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
