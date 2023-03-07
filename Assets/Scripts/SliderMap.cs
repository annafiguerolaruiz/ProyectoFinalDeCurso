using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMap : MonoBehaviour
{
    public Slider slider;
    public GameObject Ball;
    public GameObject Cubo;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = Cubo.transform.position.y + 159;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = Cubo.transform.position.y;
        Cubo.transform.position = -Ball.transform.position;
    }
}
