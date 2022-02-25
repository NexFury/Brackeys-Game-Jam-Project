using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryDialogueSpawner : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueBox;
    private float waitTime = 5f;
    private PlayerMonocle playerMonocle;
    [SerializeField] private BoxCollider2D levelProceed;
    [SerializeField] private Image levelProceedDirection;

    private void Start() 
    {
        playerMonocle = FindObjectOfType<PlayerMonocle>();
        dialogueBox.text = "Greetings, Brave Adventurer.";
        Invoke("SecondDialogue", waitTime);
    }

    private void SecondDialogue()
    {
        dialogueBox.text = "I am in a predicament. As you can see my house is in tatters. This was caused by a beast which resides in the forest near here.";
        Invoke("ThirdDialogue", waitTime);
    }

    private void ThirdDialogue()
    {
        dialogueBox.text = "Avenge me, Adventurer. Please slay the beast so that no one else meets the same fate as me.";
        Invoke("FourthDialogue", waitTime);
    }

    private void FourthDialogue()
    {
        dialogueBox.text = "However, the beast are full of creatures lurking unknown to the common eye. Here take this monocle, it'll help you see them clearly";
        Invoke("FifthDialogue",waitTime);
        //Make monocle to 3
        playerMonocle.IncrementMonocleMeter(3);
    }

    private void FifthDialogue()
    {
        dialogueBox.text = "However be wary, for the monocle is easily breakable. If you get hit, the monocle will shatter.";
        Invoke("SixthDialogue", waitTime);
    }

    private void SixthDialogue()
    {
        dialogueBox.text = "Take this box as well. If you find any glass shards within the forest. Adding them in the box will make a new monocle for you.";
        Invoke("SeventhDialogue", waitTime);
    }

    private void SeventhDialogue()
    {
        dialogueBox.text = "Off you go oh brave adventurer. Slaying the beast will surely bring you great glory. Avenge me!!!";
        Invoke("LevelProceed",waitTime);
    }

    private void LevelProceed()
    {
        dialogueBox.enabled = false;
        levelProceedDirection.enabled = true;
        levelProceed.enabled = true;
    }
}
