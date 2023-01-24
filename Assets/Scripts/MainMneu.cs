using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMneu : MonoBehaviour
{
    public void SceneLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void  SceneLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void SceneLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void SceneLevel4()
    {
        SceneManager.LoadScene("Level_4");
    }

    public void SceneLevel5()
    {
        SceneManager.LoadScene("Level_5");
    }
}
