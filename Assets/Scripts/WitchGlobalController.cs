using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchGlobalController : MonoBehaviour
{
    public bool Oryx = false;
    [SerializeField] GameObject OryxWitch;
    public bool Xya = false;
    [SerializeField] GameObject XyaWitch;
    public bool Hanah = false;
    [SerializeField] GameObject HanahWitch;
    public bool Anie = false;
    [SerializeField] GameObject AnieWitch;

    private void Start()
    {
        OryxWitch.SetActive(false);
        XyaWitch.SetActive(false);
        HanahWitch.SetActive(false);
        AnieWitch.SetActive(false);

        int i = Random.Range(1, 4);
        if(i == 1)
        {
            OryxWitch.SetActive(true);
            Oryx = true;
        }
        if (i == 2)
        {
            XyaWitch.SetActive(true);
            Xya = true;
        }
        if (i == 3)
        {
            HanahWitch.SetActive(true);
            Hanah = true;
        }
        if (i == 4)
        {
            AnieWitch.SetActive(true);
            Anie = true;
        }
    }
}
