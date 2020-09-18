using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleVolume : MonoBehaviour
{
    float volumeMax;
    public Slider sliderMax;

    void Start()
    {
        sliderMax.value = PlayerPrefs.GetFloat("Maximo");
    }

    public void VolumeMaximo(float volume)
    {
        volumeMax = volume;
        AudioListener.volume = volumeMax;

        PlayerPrefs.SetFloat("Maximo", volumeMax);
    }
}
