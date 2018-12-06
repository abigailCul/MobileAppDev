using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChanger : MonoBehaviour {

    //audio component
    private AudioSource audioSrc;

    //Music slider
    private float musicVolume = 1f;

    void Start ()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void setVolume(float vol)
    {
        musicVolume = vol;
    }

public void ToggleSound()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
