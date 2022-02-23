using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoclePickup : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerMonocle>().IncrementMonocleMeter(1);
            Destroy(this.gameObject);
        }
    }
}
