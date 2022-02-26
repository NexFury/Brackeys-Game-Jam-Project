using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Climax : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip roarClip;
    [SerializeField] private GameObject levelProceed;
    [SerializeField] private GameObject directionImage;
    // Start is called before the first frame update
    private void Start() 
    {
        audioSource = FindObjectOfType<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            this.gameObject.SetActive(false);
            dialogueText.GetComponent<TMP_Text>().color = new Color(255,0,0,255);
            dialogueText.text = "ROOOAAAAAAAAAAARRRRRR!!!!";
            audioSource.PlayOneShot(roarClip ,1f);
            Invoke("SecondText", 5f);
        }
    }

    void SecondText()
    {
        dialogueText.GetComponent<TMP_Text>().color = new Color(255,255,255,255);
        dialogueText.text = "The roar was intimidating. You felt the shivers, but you must brave on!!";
        directionImage.SetActive(true);
        levelProceed.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
