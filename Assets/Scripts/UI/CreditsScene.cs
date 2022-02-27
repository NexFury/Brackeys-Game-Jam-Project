using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScene : MonoBehaviour
{
    [SerializeField] private GameObject creditsPage1;
    [SerializeField] private GameObject creditsPage2;
    [SerializeField] private GameObject thankYouText;
    private void Start() 
    {
        StartCoroutine("CreditsDisplay");
    }

    IEnumerator CreditsDisplay()
    {
        creditsPage2.SetActive(false);
        thankYouText.SetActive(false);
        creditsPage1.SetActive(true);
        yield return new WaitForSeconds(5);
        creditsPage1.SetActive(false);
        thankYouText.SetActive(false);
        creditsPage2.SetActive(true);
        yield return new WaitForSeconds(5);
        creditsPage1.SetActive(false);
        creditsPage2.SetActive(false);
        thankYouText.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
