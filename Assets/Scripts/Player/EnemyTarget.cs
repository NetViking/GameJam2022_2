using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    private static EnemyTarget _Instance;
    public static EnemyTarget Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = GameObject.FindObjectOfType<EnemyTarget>();
            }

            return _Instance;
        }
    }
    
}
