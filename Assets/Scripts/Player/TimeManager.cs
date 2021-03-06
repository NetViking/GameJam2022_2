using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static TimeManager Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = GameObject.FindObjectOfType<TimeManager>();
            }

            return _Instance;
        }
    }

    private static TimeManager _Instance;

    public float ElapsedTime
    {
        get;
        private set;
    }

    public float DeltaTime
    {
        get { return Time.deltaTime; }
    }

    public static bool IsPaused
    {
        get;
        private set;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.IsPaused)
            return;

        ElapsedTime += Time.deltaTime;
    }

    static public void Pause()
    {
        IsPaused = true;
        Time.timeScale = 0;
    }

    static public void Unpause()
    {
        IsPaused = false;
        Time.timeScale = 1;
    }
}
