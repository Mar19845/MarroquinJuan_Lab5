using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetLevel(float volSlider)
    {
        //audioMixer.SetFloat("MusicVol", Mathf.Log10(volSlider)*20);
        audioMixer.SetFloat("MusicVol", volSlider);
    }
}
