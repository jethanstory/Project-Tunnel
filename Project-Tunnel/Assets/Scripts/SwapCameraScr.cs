using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCameraScr : MonoBehaviour
{

    public GameObject rootObject;

    public GameObject fpsPlayer;
    public GameObject currCamera;
    public GameObject nextCamera;

    public GameObject currRawImage;
    public GameObject nextRawImage;

    public float secondsCount;

    public GameObject swapCanvas;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rootObject.GetComponent<BatteryIconScr>().bigSwap)
        {
            currCamera.SetActive(false);
            nextCamera.SetActive(true);
            currRawImage.SetActive(false);
            nextRawImage.SetActive(true);
            // fpsPlayer.GetComponent<

            // swapCanvas.SetActive(true);

            // secondsCount += Time.deltaTime;
            // if (secondsCount > 2)
            //     swapCanvas.SetActive(false);

        }
    }
}
