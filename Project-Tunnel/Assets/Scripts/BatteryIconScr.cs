using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryIconScr : MonoBehaviour
{

    public float secondsCount = 0;

    public GameObject batteryFull;
    public GameObject batteryFiveSix;
    public GameObject batteryFourSix;
    public GameObject batteryThreeSix;
    public GameObject batteryTwoSix;
    public GameObject batteryOneSix;
    public GameObject batteryZeroSix;

    public GameObject recObject;
    public GameObject lightObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BatteryCheck();
    }


    void BatteryCheck()
    {
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
                                if (secondsCount >= 380)
                                {
                                    batteryZeroSix.SetActive(false);
                                    recObject.SetActive(false);
                                    lightObject.SetActive(false);

                                }
                            }
                        }

                    }

                }
            }
        }
    }

    void BlinkingIcon()
    {

    }
}
