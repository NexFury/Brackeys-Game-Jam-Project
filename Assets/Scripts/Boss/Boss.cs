using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform player;
    public bool isFlipped;
    public ClimaxDialogue climaxDialogue;
    public AudioSource audioSource;
    [SerializeField] private AudioClip fightClip;
    [SerializeField] private AudioClip successClip;

    private void Start() 
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(fightClip, 1f);
        climaxDialogue = FindObjectOfType<ClimaxDialogue>();
        Invoke("BossDie", 15f);
    }

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if(transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if(transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player" && gameObject.GetComponent<BoxCollider2D>())
        {
            other.GetComponent<PlayerHealth>().TakeDamage(10);
        }
    }

    private void BossDie()
    {
        audioSource.PlayOneShot(successClip, 0.5f);
        climaxDialogue.BossDeadDialogue();
        Destroy(gameObject);
    }
}
