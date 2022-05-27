using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceTerrorController : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<AudioSource>().enabled = false;
    }
    public void ActiveVoice()
    {
        gameObject.GetComponent<AudioSource>().enabled = true;
    }
    public void DesactiveVoice()
    {
        gameObject.GetComponent<AudioSource>().enabled = false;
    }
}
