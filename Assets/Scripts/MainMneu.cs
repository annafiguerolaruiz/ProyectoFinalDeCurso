using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMneu : MonoBehaviour
{
    //Change scenes
    public void SceneLevel(int value)
    {
        GameManager.GM.CurrentLevel = value;
        SceneManager.LoadScene(GameManager.GM.CurrentLevel);
    }
}
