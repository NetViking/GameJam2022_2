using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    CharMovement characterMover;
    bool isQuitting = false;

    // Start is called before the first frame update
    void Start()
    {
        characterMover = GetComponent<CharMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.IsPaused)
            return;

        characterMover.DesiredDirection = new Vector2(
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical")
            );

        if (Input.GetKeyDown(KeyCode.F4))
        {
            GetComponent<Health>().Die();
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            PlayerPrefs.DeleteAll();
        }

    }

    
    private void OnApplicationQuit()
    {
        isQuitting = true;
    }


    private void OnDestroy()
    {
        if (isQuitting)
            return;

        DialogManager.Instance.DoDialog_Legacy();
    }

}
