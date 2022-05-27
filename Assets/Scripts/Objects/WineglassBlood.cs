using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineglassBlood : MonoBehaviour
{
    [SerializeField] GameObject bloodFull;
    [SerializeField] GameObject bloodDrinker;
    [SerializeField] GameObject WaterFull;
    [SerializeField] GameObject WaterDrinker;

    // Start is called before the first frame update
    void Start()
    {
        bloodDrinker.SetActive(false);
        bloodFull.SetActive(false);
        WaterDrinker.SetActive(false);
    }

    public void DrinkBlood()
    {
        bloodDrinker.SetActive(true);
        WaterFull.SetActive(false);
    }

    public void DrinkWater()
    {
        WaterDrinker.SetActive(true);
        WaterFull.SetActive(false);
    }

    public void OnlyBlood()
    {
        bloodFull.SetActive(true);
        WaterFull.SetActive(false);
    }
}
