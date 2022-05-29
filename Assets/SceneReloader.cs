using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Dummy loaded");
        SceneManager.LoadScene("GameScene");
    }

}
