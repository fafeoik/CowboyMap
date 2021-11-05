using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePlayer : MonoBehaviour
{
    public AudioSource loseSound;
    public AudioSource winSound;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F6))
        {
            loseSound.Play();
        }
        else if(Input.GetKeyDown(KeyCode.F7))
        {
            winSound.Play();
        }
    }
}
