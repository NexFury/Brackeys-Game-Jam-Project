using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMonocle : MonoBehaviour
{
    private int monocleCounter = 0;
    [SerializeField] private Image monocle_0;
    [SerializeField] private Image monocle_1;
    [SerializeField] private Image monocle_2;

    private void Start() 
    {
        UpdateMonocleMeter();     
    }

    private void Update() 
    {
        
    }

    private void UpdateMonocleMeter()
    {
        if(monocleCounter == 0)
        {
            monocle_0.enabled = false;
            monocle_1.enabled = false;
            monocle_2.enabled = false;
        }
        else if(monocleCounter == 1)
        {
            monocle_0.enabled = false;
            monocle_1.enabled = false;
            monocle_2.enabled = true;
        }
        else if(monocleCounter == 2)
        {
            monocle_0.enabled = false;
            monocle_1.enabled = true;
            monocle_2.enabled = true;
        }
        else if(monocleCounter == 3)
        {
            monocle_0.enabled = true;
            monocle_1.enabled = true;
            monocle_2.enabled = true;
        }
    }
}
