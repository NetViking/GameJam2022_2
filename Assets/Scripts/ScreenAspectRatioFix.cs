using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenAspectRatioFix : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        if (Screen.width / Screen.height  > 16f/9f)
        {
            GetComponent<CanvasScaler>().matchWidthOrHeight = 1f;
        }
        else
        {
            GetComponent<CanvasScaler>().matchWidthOrHeight = 0f; 
        }
    }
}
