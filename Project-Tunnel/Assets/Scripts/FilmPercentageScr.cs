using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FilmPercentageScr : MonoBehaviour
{
    bool canpickup; //a bool to see if you can or cant pick up the item
    GameObject ObjectIwantToDestroy; // the gameobject onwhich you collided with

    public int filmPercentageCount = 0;
    public float secondsCountInital;
    public GameObject initalHint;
    public GameObject playerNotes;
    public GameObject playerNotesOld;
    bool activeNotes;
    bool activeNotesOld;
    public GameObject rootObject;
    public GameObject fpsPlayer;
    public Text Txt;
    public TMPro.TMP_Text percentageAmount;
    public TMPro.TMP_Text percentageAmountOld;

    public GameObject rustyKnifeInven;
    public GameObject flimsySawInven;
    public GameObject allenKeyInven;
    public GameObject crateCrowbarInven;

    public GameObject rustyKnifeInvenOld;
    public GameObject flimsySawInvenOld;
    public GameObject allenKeyInvenOld;
    public GameObject crateCrowbarInvenOld;
    // public TMPro.TextMeshProUGUI percentageAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        secondsCountInital += Time.deltaTime;
        initalHint.SetActive(true);
        if (secondsCountInital > 3)
        {
            initalHint.SetActive(false);
            secondsCountInital = 4;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            checkNotes();
        }
        if (rootObject.GetComponent<BatteryIconScr>().bigSwap && Input.GetKeyDown(KeyCode.Tab))
        {
            checkNotesOld();
        }
    }

    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        if (other.gameObject.tag == "FilmTrig") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            ObjectIwantToDestroy = other.gameObject; //set the gameobject you collided with to one you can reference
            Destroy(ObjectIwantToDestroy);
            filmPercentageCount += 2;
        }
    }
    private void OnTriggerExit(Collider other)
    {

    }

    public void checkNotes()
    {
        if (activeNotes)
        {
            activeNotes = false;
            // Txt = GameObject.Find ("NoteText").GetComponent<Text> ();

            //Txt = GameObject.Find("PercentageCount").GetComponent<TMPro.TextMeshProUGUI>().text;
            //Txt.text = filmPercentageCount.ToString();

            percentageAmount.text = " ";

            //GetComponent<TMPro.TextMeshProUGUI>().text

            // Time.timeScale = 1;
            // Cursor.lockState = CursorLockMode.Locked;
            // Cursor.visible = false;
            playerNotes.SetActive(false);
        }
        else
        {
            activeNotes = true;
            percentageAmount.text = filmPercentageCount.ToString();
            if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().rustyKnifePickup)
            {
                rustyKnifeInven.SetActive(true);
            }
            if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().crateCrowbarPickup)
            {
                crateCrowbarInven.SetActive(true);
            }
            if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().allenKeyPickup)
            {
                allenKeyInven.SetActive(true);
            }
            if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().flimsySawPickup)
            {
                flimsySawInven.SetActive(true);
            }
            // Time.timeScale = 0;
            // Cursor.lockState = CursorLockMode.None;
            // Cursor.visible = true;
            playerNotes.SetActive(true);

        }
    }

    public void checkNotesOld()
    {
        if (activeNotesOld)
        {
            activeNotesOld = false;
            percentageAmountOld.text = " ";
            // Time.timeScale = 1;
            // Cursor.lockState = CursorLockMode.Locked;
            // Cursor.visible = false;
            playerNotesOld.SetActive(false);
        }
        else
        {
            activeNotesOld = true;
            // Time.timeScale = 0;
            percentageAmountOld.text = filmPercentageCount.ToString();

            if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().rustyKnifePickup)
            {
                rustyKnifeInvenOld.SetActive(true);
            }
            if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().crateCrowbarPickup)
            {
                crateCrowbarInvenOld.SetActive(true);
            }
            if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().allenKeyPickup)
            {
                allenKeyInvenOld.SetActive(true);
            }
            if (fpsPlayer.GetComponent<PickupOtherGoalItemsScr>().flimsySawPickup)
            {
                flimsySawInvenOld.SetActive(true);
            }
            // Cursor.lockState = CursorLockMode.None;
            // Cursor.visible = true;
            playerNotesOld.SetActive(true);

        }
    }

}
