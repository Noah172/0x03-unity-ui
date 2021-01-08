using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    // // public Button optionsButton;
    // // public Button backButton;
    // // public GameObject mainMenu;
    // // public GameObject optionMenu;
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
        quitButton.onClick.AddListener(QuitMaze);
        // optionsButton.onClick.AddListener(OptionsMenu);
        // backButton.onClick.AddListener(BackToMain);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayMaze()
    {
        if (colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }
        SceneManager.LoadScene("maze");
    }
    public void QuitMaze()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
    // public void OptionsMenu()
    // {
    //     mainMenu.SetActive(false);
    //     optionMenu.SetActive(true);
    // }
    // public void BackToMain()
    // {
    //     mainMenu.SetActive(true);
    //     optionMenu.SetActive(false);
    // }
}
