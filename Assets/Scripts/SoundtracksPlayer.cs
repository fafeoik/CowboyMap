using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundtracksPlayer : MonoBehaviour
{
    public AudioSource[] Sound;

    int RandomNumber;
    void Start()
    {
        RandomNumber = Random.Range(0, Sound.Length);
        Sound[RandomNumber].Play();
    }

    void Update()
    {
        if (!Sound[RandomNumber].isPlaying)
        {
            RandomNumber = Random.Range(0, Sound.Length);
            Sound[RandomNumber].Play();
        }

    }
}
