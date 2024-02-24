using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingRecordScr : MonoBehaviour
{
    public Image image;

    public Image recordIcon;
    public Image recordIconNoDot;

    void Start()
    {
        // image = GetComponent<Image>();
        StartBlinking();
    }


    IEnumerator Blink()
    {
        while (true)
        {
            switch (image.color.a.ToString())
            {
                case "0":
                    image.color = new Color(image.color.r, image.color.g, image.color.b, 1);

                    // recordIcon.SetActive(true);
                    // recordIconNoDot.SetActive(false);

                    // recordIcon.color = new Color(recordIcon.color.r, recordIcon.color.g, recordIcon.color.b, 1);
                    // recordIconNoDot.color = new Color(recordIconNoDot.color.r, recordIconNoDot.color.g, recordIconNoDot.color.b, 0);

                    //Play sound
                    yield return new WaitForSeconds(0.5f);
                    break;
                case "1":
                    image.color = new Color(image.color.r, image.color.g, image.color.b, 0);

                    // recordIcon.SetActive(false);
                    // recordIconNoDot.SetActive(true);

                    // recordIcon.color = new Color(recordIcon.color.r, recordIcon.color.g, recordIcon.color.b, 0);
                    // recordIconNoDot.color = new Color(recordIconNoDot.color.r, recordIconNoDot.color.g, recordIconNoDot.color.b, 1);

                    //Play sound
                    yield return new WaitForSeconds(0.5f);
                    break;
            }
        }
    }

    void StartBlinking()
    {
        StopAllCoroutines();
        StartCoroutine("Blink");
    }

    void StopBlinking()
    {
        StopAllCoroutines();
    }
}
