using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDecay : MonoBehaviour
{
    Health health;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        health.ChangeHP(-Time.deltaTime, false);
    }
}
