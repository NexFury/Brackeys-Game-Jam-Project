using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAvacado : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().Heal(35);
            Destroy(gameObject);
        }
    }
}
