using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CassetScript : MonoBehaviour
{
    AudioSource audio;
    [SerializeField] AudioSource audioStart;
    [SerializeField] AudioSource audioNoise;
    bool AudioCasset = false;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (AudioCasset)
        {
            audioStart.enabled = true;
            audio.enabled = true;
            audioNoise.enabled = true;
        }

        else
        {
            audioStart.enabled = false;
            audio.enabled = false;
            audioNoise.enabled = false;
        }
    }

    public void ActiveCasset()
    {
        AudioCasset = true;
    }
    public void DesactiveCasset()
    {
        AudioCasset = false;
    }
}
