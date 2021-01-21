using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{
    public AudioMixer musicAudioMixer;
    public AudioMixer fxAudioMixer;
    public void SetMusicVolume (float volume)
    {
        musicAudioMixer.SetFloat("musicVolume", volume);
    }

    public void SetFXVolume (float volume)
    {
        fxAudioMixer.SetFloat("fxVolume", volume);
    }

}