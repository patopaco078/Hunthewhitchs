using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEventController : MonoBehaviour
{
    public float ActiveTime;
    public float InactiveTime;
    float TimerActive;
    float TimerInactive;

    public bool activemode; //sirve para que los fantasmas puedan atacar

    bool Active =true;
    bool OneActivation = true;
    [SerializeField] Parpados parpados;

    [SerializeField] UnityEvent OnActive;
    [SerializeField] UnityEvent OnInactive;

    [SerializeField] WitchController OryxWitch;
    [SerializeField] WitchController XyaWitch;
    [SerializeField] WitchController HanahWitch;
    [SerializeField] WitchController AnieWitch;

    [SerializeField] GameObject hanahExeption;

    WitchGlobalController witchGlobal;

    private void Start()
    {
        witchGlobal = gameObject.GetComponent<WitchGlobalController>();
        TimerActive = ActiveTime;
        TimerInactive = InactiveTime;
    }
    private void Update()
    {
        if (Active)
        {
            if(TimerActive > 0)
            {
                TimerActive -= Time.deltaTime;
                activemode = true;
                ActivarEventos();
            }
            else
            {
                Active = false;
                TimerActive = ActiveTime-5;
            }
        }
        else
        {
            DesactivarEventos();
            if (TimerInactive > 0)
            {
                TimerInactive -= Time.deltaTime;
                activemode = false;
                DesactivarEventos();
            }
            else
            {
                Active = true;
                TimerInactive = InactiveTime;
            }
        }
    }

    void ActivarEventos()
    {
        if (OneActivation)
        {
            OnActive.Invoke();
            StartCoroutine(ParpadeActive());
            OneActivation = false;

            if(hanahExeption.activeSelf)
            {
                HanahWitch.EventsActiveWitch1.Invoke();
            }
        }
    }
    void DesactivarEventos()
    {
        if (!OneActivation)
        {
            if (witchGlobal.Oryx)
            {
                OryxWitch.EventsWitchInactive();
            }
            if (witchGlobal.Xya)
            {
                XyaWitch.EventsWitchInactive();
            }
            if (witchGlobal.Hanah)
            {
                HanahWitch.EventsWitchInactive();
            }
            if (witchGlobal.Anie)
            {
                AnieWitch.EventsWitchInactive();
            }

            OnInactive.Invoke();
            StartCoroutine(ParpadeDesactive());
            OneActivation = true;
        }
    }

    IEnumerator ParpadeActive()
    {
        yield return new WaitForSeconds(ActiveTime - 1);
        parpados.CerrarOjos = true;
    }
    IEnumerator ParpadeDesactive()
    {
        yield return new WaitForSeconds(InactiveTime - 1);
        parpados.CerrarOjos = false;
    }
}
