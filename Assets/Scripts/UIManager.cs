using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    //Record texts on screen:
    public TextMeshProUGUI CurrentScoreText;
    public TextMeshProUGUI BestScoreText;
  

    void Update()
    {
        CurrentScoreText.text = "Score:" + GameManager.GM.CurrentScore;
        BestScoreText.text = "Best:" + GameManager.GM.BestScore;
    }
}
