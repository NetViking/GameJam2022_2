using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowWiggle : MonoBehaviour
{
    float t = 0;
    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        this.transform.localPosition = new Vector3(Mathf.Sin(t * 10f) / 4f - 0.5f, 0, 0);
    }
}
