using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ClimaxDialogue : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;
    public void BossDeadDialogue()
    {
        dialogueText.text = "Congratulations on beating the boss!!!!";
        StartCoroutine("ApologyNotice");
    }

    IEnumerator ApologyNotice()
    {
        yield return new WaitForSeconds(5);
        dialogueText.text = "Sorry, this fight was originally supposed to be EPIC but I was unable to complete it in time. Hence he dies after 15 seconds has passed";
        yield return new WaitForSeconds(5);
        dialogueText.text = "I apologize for the poor execution. I'll be a better scripter and try to do my part properly next time.  -Nex1412";
        yield return new WaitForSeconds(5);
        dialogueText.text = "Anyways, apology done. Onwards to the next scene";
        Invoke("NextScene", 3f);
    }

    private void NextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
