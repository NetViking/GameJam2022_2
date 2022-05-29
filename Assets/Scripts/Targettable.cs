using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targettable : MonoBehaviour
{
    void OnEnable()
    {
        AllTargets.Add(this);
    }

    private void OnDisable()
    {
        AllTargets.Remove(this);
    }

    public static HashSet<Targettable> AllTargets = new HashSet<Targettable>();
}
