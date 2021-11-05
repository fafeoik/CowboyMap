using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource Audio;
    public GameObject PlaceInfo;
    public bool isWinButton;
    float invokeTime;

    [SerializeField]
    public bool developerModeActive = false;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F10))
        {
            developerModeActive = true;
        }
    }
    public void PlaySound()
    {

        if (!developerModeActive)
        {

            Audio.Play();
            if (isWinButton)
            {
                invokeTime = 7.5f;
            }
            else
            {
                invokeTime = 5;
            }
            Invoke("SetUnactive", invokeTime);
        }
        else
        {
            SetUnactive();
        }


    }

    public void SetUnactive()
    {
        PlaceInfo.SetActive(false);
    }
}
