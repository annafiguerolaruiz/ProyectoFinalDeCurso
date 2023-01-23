using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int BestScore;
    public int CurrentScore;
    public int CurrentLevel = 0;
    public static GameManager GM;

    void Awake()
    {
        //We are going to eliminate the remaining game managers so that only one remains on the scene
        if (GM==null)
        {
            GM = this;
        }
        else if (GM!=this)
        {
            Destroy(gameObject);
        }
        //Our best score will be the variable that we have saved below
        BestScore = PlayerPrefs.GetInt("HighScore");

    }
    public void NextLevel()
    {

    }
    public void RestartLevel()
    {
        //We reset score
        GM.CurrentScore = 0;

        //We find our "JumpController" script
        FindObjectOfType<JumpBall>().ResetBall();
    }
    public void AddScore(int scoretoAdd)
    {
        CurrentScore += scoretoAdd;
        if (CurrentScore>BestScore)
        {
            BestScore = CurrentScore;
            //We keep best score of the game:
            PlayerPrefs.SetInt("HighScore", CurrentScore);
        }
    }

}
