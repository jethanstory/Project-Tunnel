using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCameraScr : MonoBehaviour
{

    public GameObject rootObject;
    public GameObject currCamera;
    public GameObject nextCamera;

    public GameObject currRawImage;
    public GameObject nextRawImage;


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
        }
    }
}
