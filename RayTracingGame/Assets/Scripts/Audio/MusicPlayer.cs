﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    private float musicVolume=1f;
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
    }

    public void updateVolume1(float volume) {
        musicVolume = volume;
    }

}
