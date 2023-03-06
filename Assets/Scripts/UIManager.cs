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

    public Slider slider;
    public Text ActualLevel;
    public Text NextLevel;

    public Transform topTransform;
    public Transform goalTransform;

    public Transform ball;


    void Update()
    {
        CurrentScoreText.text = "Score:" + GameManager.GM.CurrentScore;
        BestScoreText.text = "Best:" + GameManager.GM.BestScore;

      //  ChangeSliderLevelAnProgress();
    }


   // public void ChangeSliderLevelAnProgress()
    //{
     

       /* float totalDistance = (topTransform.position.y = goalTransform.position.y);
        float distanceLeft = totalDistance = (ball.transform.position.y - goalTransform.position.y);
        float value = (distanceLeft / totalDistance);
        slider.value = Mathf.Lerp(slider.value,value,5);
    }*/

}
