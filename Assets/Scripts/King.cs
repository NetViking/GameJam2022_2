using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : MonoBehaviour
{
    Health health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();

    }

    public static King Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = GameObject.FindObjectOfType<King>();
            }

            return _Instance;
        }
    }
    private static King _Instance;

    // Update is called once per frame
    void Update()
    {
        health.ChangeHP(-TimeManager.Instance.DeltaTime);
    }
}
