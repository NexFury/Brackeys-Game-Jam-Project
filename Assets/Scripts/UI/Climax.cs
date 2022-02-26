using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Climax : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private AudioSource audio;
    [SerializeField] private AudioClip roarClip;
    // Start is called before the first frame update
    private void Start() 
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            dialogueText.GetComponent<TMP_Text>().color = new Color(255,0,0,255);
            dialogueText.text = "ROOOAAAAAAAAAAARRRRRR!!!!";
            audio.PlayOneShot(roarClip ,1f);
            Invoke("SecondText", 5f);
        }
    }

    void SecondText()
    {
        dialogueText.GetComponent<TMP_Text>().color = new Color(255,255,255,255);
        dialogueText.text = "The roar was intimidating. You felt the shivers, but you must brave on!!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
