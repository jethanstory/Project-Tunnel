using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryIconScr : MonoBehaviour
{

    public float secondsCount = 0;

    public float secondsDown = 0;

    public GameObject batteryFull;
    public GameObject batteryFiveSix;
    public GameObject batteryFourSix;
    public GameObject batteryThreeSix;
    public GameObject batteryTwoSix;
    public GameObject batteryOneSix;
    public GameObject batteryZeroSix;

    public GameObject recObject;
    public GameObject lightObject;
    public Image image;
    public GameObject recDotObject;

    public bool hasBattery = true;
    public bool isOut = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasBattery)
        {
            BatteryCheck();
        }

        if (isOut)
        {
            BatteryReset();
        }

    }


    void BatteryCheck()
    {
        secondsDown = 0;
        secondsCount += Time.deltaTime;

        if (secondsCount > 60)
        {
            batteryFull.SetActive(false);
            batteryFiveSix.SetActive(true);
            if (secondsCount >= 120)
            {
                batteryFiveSix.SetActive(false);
                batteryFourSix.SetActive(true);
                if (secondsCount >= 180)
                {
                    batteryFourSix.SetActive(false);
                    batteryThreeSix.SetActive(true);
                    if (secondsCount >= 240)
                    {
                        batteryThreeSix.SetActive(false);
                        batteryTwoSix.SetActive(true);
                        if (secondsCount >= 300)
                        {
                            batteryTwoSix.SetActive(false);
                            batteryOneSix.SetActive(true);
                            if (secondsCount >= 360)
                            {
                                batteryOneSix.SetActive(false);
                                batteryZeroSix.SetActive(true);

                                recObject.SetActive(false);
                                recDotObject.SetActive(false);
                                StopAllCoroutines();

                                StartBlinking();
                                if (secondsCount >= 390)
                                {
                                    // StopBlinking();
                                    StopAllCoroutines();

                                    batteryZeroSix.SetActive(false);
                                    recObject.SetActive(false);
                                    lightObject.SetActive(false);
                                    recDotObject.SetActive(false);
                                    hasBattery = false;
                                    isOut = true;

                                }
                            }
                        }

                    }

                }
            }
        }
    }





    IEnumerator Blink()
    {
        while (true)
        {
            switch (image.color.a.ToString())
            {
                case "0":
                    image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
                    //Play sound
                    yield return new WaitForSeconds(0.5f);
                    break;
                case "1":
                    image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
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

    void BatteryReset()
    {
        secondsDown += Time.deltaTime;
        if (secondsDown > 7)
        {
            secondsCount = 0;
            isOut = false;
            hasBattery = true;
            batteryFull.SetActive(true);
            recObject.SetActive(true);
            lightObject.SetActive(true);
            recDotObject.SetActive(true);
        }
    }

}

