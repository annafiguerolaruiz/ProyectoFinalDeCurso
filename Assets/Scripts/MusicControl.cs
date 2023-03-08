using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicControl : MonoBehaviour
{

    public AudioSource ASource;
    public Slider volumeSlider;
    public float MusicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        ASource.Play();
        MusicVolume = PlayerPrefs.GetFloat("volume");
        ASource.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        ASource.volume = MusicVolume;
        PlayerPrefs.SetFloat("volume", MusicVolume);
    }

    public void VolumeUpdater(float volume)
    {
        MusicVolume = volumeSlider.value;
    }

}
