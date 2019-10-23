using UnityEngine;
using System.Collections;

public class DieOnHit : MonoBehaviour
{
    //Kill enemy gameObject, if hitBox is triggering
    private void OnTriggerEnter(Collider other)
    {
        var enemy = transform.GetComponentInParent<EnemyBehavior>();
        enemy.Die();
    }
}
