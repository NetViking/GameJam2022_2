using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagesOnCollision : MonoBehaviour
{
    void Start()
    {
        characterMover = GetComponent<CharMovement>();
    }

    CharMovement characterMover;

    public float BlinkDistanceOnCollision = 0;

    public float Damage = 1;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        EnemyTarget et = collision.gameObject.GetComponentInParent<EnemyTarget>();

        if (et == null)
        {
            // Collided with something that isn't our target (probably a wall).
            return;
        }


        Health health = collision.gameObject.GetComponentInParent<Health>();

        if (health == null)
        {
            // Collided with something that doesn't have health
            Debug.LogError("EnemyTarget doesn't actually have health?!?!?");
            return;
        }

        health.ChangeHP(-Damage);

        if (BlinkDistanceOnCollision > 0)
        {
            characterMover.BlinkAwayFromTarget(collision.transform, BlinkDistanceOnCollision);
        }
    }
}
