using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMneu : MonoBehaviour
{

    public GameObject Settings;
    //Change scenes
    public void SceneLevel(int value)
    {
        GameManager.GM.CurrentLevel = value;
        SceneManager.LoadScene(GameManager.GM.CurrentLevel);
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void Niveles()
    {
        SceneManager.LoadScene("Levels");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Start()
    {
        Settings.SetActive(false);
    }
    public void SettingsButton()
    {
        if (Settings.activeInHierarchy == false) { Settings.SetActive(true); } else { Settings.SetActive(false); }
        
    }


}
