using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhantomsActivity : MonoBehaviour
{
    [SerializeField] Phantoms PhantomsScript;
    [SerializeField] Shake shake;
    [SerializeField] GameObject playerController;
    Quaternion rotationNeed = Quaternion.Euler(0, 180, 0);

    private bool isrotate = false;


    //--------------------parte2----------------
    [SerializeField] DeathController deathController;
    [SerializeField] GlobalEventController globalEventController;
    public float Timer;
    

    private void Update()
    {
        
        if (PhantomsScript.IsAInofensive)
        {
            deathInactive();
        }
        if (PhantomsScript.IsADemon)
        {
            ActivityDemon();
        }


        if(playerController.GetComponent<Transform>().rotation == rotationNeed)
        {
            isrotate = true;
        }
        if(!(playerController.GetComponent<Transform>().rotation == rotationNeed))
            isrotate = false;
        if (isrotate && Input.GetKeyDown(KeyCode.F))
        {
            if (PhantomsScript.IsADemon)
                shake.IsShake = true;
            if (PhantomsScript.IsAInofensive)
                shake.inofensiveActive = true;
        }
        if (isrotate && Input.GetKeyUp(KeyCode.F))
        {
            if (PhantomsScript.IsADemon)
                shake.IsShake = false;
            if (PhantomsScript.IsAInofensive)
                shake.inofensiveActive = false;
        }

    }

    void deathInactive()
    {
        if (globalEventController.activemode)
        {
            if (Timer > 0)
            {
                Timer -= Time.deltaTime;
            }
            else
            {
                deathController.Kill();
            }
        }
    }

    void ActivityDemon()
    {
        if (globalEventController.activemode)
        {
            if (Timer > 0)
            {
                Timer -= Time.deltaTime;
            }
            else
            {
                PhantomsScript.PruebaFalsa = true;
                PhantomsScript.DesactiveDemon();
            }
        }
    }

}
