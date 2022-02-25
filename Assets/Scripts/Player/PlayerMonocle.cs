using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMonocle : MonoBehaviour
{
    public int monocleCounter = 0;
    public MonocleMeter monocleMeter;

    private void Awake() 
    {
        
    }

    private void Start() 
    {
        monocleMeter = FindObjectOfType<MonocleMeter>();
        monocleMeter.UpdateMonocleMeter(monocleCounter);     
    }

    private void Update() 
    {
        
    }

    public void IncrementMonocleMeter(int monocleShard)
    {
        monocleCounter += monocleShard;
        monocleMeter.UpdateMonocleMeter(monocleCounter);
    }

    public void MonocleDestroyed()
    {
        monocleCounter = 0;
        monocleMeter.UpdateMonocleMeter(monocleCounter);
    }
}
