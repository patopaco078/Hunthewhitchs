using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelaControllerScript : MonoBehaviour
{
    [SerializeField] GameObject vela1;
    [SerializeField] GameObject vela2;
    [SerializeField] GameObject vela3;
    [SerializeField] GlobalEventController globalEventController;

    int vidas = 4;
    bool oneAttemp = true;
    bool twoAttemp = true;
    bool threeAttemp = true;

    private void Update()
    {
        bajarTiempoActivo();
    }

    void bajarTiempoActivo()
    {
        if (oneAttemp && vidas == 3)
        {
            globalEventController.ActiveTime -= 5;
            oneAttemp = false;
            vela1.SetActive(false);
        }
        if (twoAttemp && vidas == 2)
        {
            globalEventController.ActiveTime -= 5;
            twoAttemp = false;
            vela2.SetActive(false);
        }
        if (threeAttemp && vidas == 1)
        {
            globalEventController.ActiveTime -= 5;
            threeAttemp = false;
            vela3.SetActive(false);
        }

    }

    public void BajarVida()
    {
        vidas--;
    }
}
