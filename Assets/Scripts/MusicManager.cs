using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public GameObject MM;
  
    // Update is called once per frame
    void Update()
    {
        //The music in the menu is canceled when going through any of these scenes
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MainMenu")
        { MM.SetActive(true); }
        else if (scene.name == "Level_1")
        {
            MM.SetActive(false); 
        }
        else if (scene.name == "Level_2")
        {
            MM.SetActive(false);
        }
        else if (scene.name == "Level_3")
        {
            MM.SetActive(false);
        }
        else if (scene.name == "Level_4")
        {
            MM.SetActive(false);
        }
        else if (scene.name == "Level_5")
        {
            MM.SetActive(false);
        }
    }
}
