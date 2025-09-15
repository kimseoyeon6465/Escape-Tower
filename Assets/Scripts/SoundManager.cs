using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicsource;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }
}
