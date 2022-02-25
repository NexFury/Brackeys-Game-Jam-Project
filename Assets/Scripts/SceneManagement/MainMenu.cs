using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject titleText;
    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject instructionsButton;
    [SerializeField] private GameObject quitButton;
    [SerializeField] private GameObject instructionsText;
    [SerializeField] private GameObject closeButton;
    private int currentSceneIndex;

    public void StartGame()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void Instructions()
    {
        titleText.SetActive(false);
        startButton.SetActive(false);
        instructionsButton.SetActive(false);
        quitButton.SetActive(false);
        instructionsText.SetActive(true);
        closeButton.SetActive(true);
    }

    public void CloseButton()
    {
        titleText.SetActive(true);
        startButton.SetActive(true);
        instructionsButton.SetActive(true);
        quitButton.SetActive(true);
        instructionsText.SetActive(false);
        closeButton.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
