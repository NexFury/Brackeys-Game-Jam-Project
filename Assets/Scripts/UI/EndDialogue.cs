using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndDialogue : MonoBehaviour
{
    [SerializeField] TMP_Text dialogueSpawner;
    private float waitTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        dialogueSpawner.text = "Villager: Greetings, Adventurer. What brings you out here in the boonies?";
        Invoke("PlayerFirst", waitTime);
    }

    private void PlayerFirst()
    {
        dialogueSpawner.text = "Adventurer: Where is this place? Where is the broken shack? I've come back to report about the beast in the forest.";
        Invoke("VillagerSecond",waitTime);
    }

    private void VillagerSecond()
    {
        dialogueSpawner.text = "Villager: This place has been peaceful for as long as I can remember, There's no beast in the woods.";
        Invoke("PlayerSecond", waitTime);
    }

    private void PlayerSecond()
    {
        dialogueSpawner.text = "Adventurer: B-but.... My Glory?";
        Invoke("VillagerThird", waitTime);
    }

    private void VillagerThird()
    {
        dialogueSpawner.text = "Villager: You must be exhausted after your long travels. I suggest you book an Inn here and get yourself together";
        Invoke("LevelProceed", 5f);
    }

    private void LevelProceed()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
