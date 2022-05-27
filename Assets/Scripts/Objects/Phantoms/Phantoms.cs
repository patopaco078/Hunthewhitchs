using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Phantoms : MonoBehaviour
{
    [SerializeField] GameObject phantomDemon;
    [SerializeField] GameObject phantomInofensive;
    [SerializeField] Shake shake;

    //----------------Activador de los fantasmas---------------
    [SerializeField] GlobalEventController globalEventController;
    public float TimePhantoms = 10;
    float TimerPhantoms;
    bool canAppear = false;
    [SerializeField] UnityEvent DemonPrueba1;
    [SerializeField] UnityEvent DemonPrueba2;
    [SerializeField] UnityEvent DemonPrueba3;
    [SerializeField] UnityEvent DemonPrueba4;
    [SerializeField] UnityEvent DemonPrueba5;
    [SerializeField] UnityEvent DemonPrueba6;
    public bool PruebaFalsa = false;

    [SerializeField] bool Active = false;

    public bool IsADemon = false;
    public bool IsAInofensive = false;

    public float DemonDuration = 3f;
    public float InofensiveDuration = 2f;

    private void Start()
    {
        TimerPhantoms = TimePhantoms;
        phantomDemon.SetActive(false);
        phantomInofensive.SetActive(false);
    }

    private void Update()
    {
        ActivePhantom();
        if (Active)
        {
            float i = Mathf.Round(Random.Range(0f, 1f));
            if(i == 0)
            {
                ActiveDemon();
            }
            if(i == 1)
            {
                ActiveInofensive();
            }
            Active = false;
        }
    }

    public void ActiveDemon()
    {
        phantomDemon.SetActive(true);
        IsADemon = true;
    }
    public void DesactiveDemon()
    {
        phantomDemon.SetActive(false);
        IsADemon = false;
        shake.IsShake = false;
    }

    public void ActiveInofensive()
    {
        phantomInofensive.SetActive(true);
        IsAInofensive = true;
    }
    public void DesactiveInofensive()
    {
        phantomInofensive.SetActive(false);
        IsAInofensive = false;
    }

    void ActivePhantom()
    {
        if (globalEventController.activemode)
        {
            if(TimerPhantoms > 0)
            {
                TimerPhantoms -= Time.deltaTime;
            }
            else
            {
                Active = true;
                phantomDemon.GetComponent<PhantomsActivity>().Timer = 5f;
                phantomInofensive.GetComponent<PhantomsActivity>().Timer = 8f;
                TimerPhantoms = TimePhantoms;
            }
        }
    }

    public void restarTimer()
    {
        phantomDemon.GetComponent<PhantomsActivity>().Timer = 5f;
        phantomInofensive.GetComponent<PhantomsActivity>().Timer = 8f;
    }

    public void DarPruebaFalsa()
    {
        if (PruebaFalsa)
        {
            int i = Random.Range(1, 6);
            UnityEvent eventoElegido;
            if(i == 1)
            {
                eventoElegido = DemonPrueba1;
                eventoElegido.Invoke();
                PruebaFalsa = false;
            }
            if (i == 2)
            {
                eventoElegido = DemonPrueba2;
                eventoElegido.Invoke();
                PruebaFalsa = false;
            }
            if (i == 3)
            {
                eventoElegido = DemonPrueba3;
                eventoElegido.Invoke();
                PruebaFalsa = false;
            }
            if (i == 4)
            {
                eventoElegido = DemonPrueba4;
                eventoElegido.Invoke();
                PruebaFalsa = false;
            }
            if (i == 5)
            {
                eventoElegido = DemonPrueba5;
                eventoElegido.Invoke();
                PruebaFalsa = false;
            }
            if (i == 6)
            {
                eventoElegido = DemonPrueba6;
                eventoElegido.Invoke();
                PruebaFalsa = false;
            }
        }
    }
}
