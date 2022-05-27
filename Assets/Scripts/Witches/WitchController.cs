using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WitchController : MonoBehaviour
{
    UnityEvent ActiveEvents;
    UnityEvent InactiveEvents;
    public UnityEvent EventsActiveWitch1;

    [SerializeField] DeathController kill;

    [SerializeField] UnityEvent EventsInactiveWitch1;
    bool event1I = false;
    [SerializeField] UnityEvent EventsInactiveWitch2;
    bool event2I = false;
    [SerializeField] UnityEvent EventsInactiveWitch3;
    bool event3I = false;

    int a = 0;
    int i = 1;


    public void EventsWitchActive()
    {
        ActiveEvents.Invoke();
    }
    public void EventsWitchInactive()
    {

        StartCoroutine(ActionElection());
    }

    IEnumerator ActionElection()
    {
        bool b = true;
        if (event1I && event2I && event3I)
        {
            StartCoroutine(killplayer());
        }

            if (i == 1 && !event1I)
            {
                InactiveEvents = EventsInactiveWitch1;
                event1I = true;
                b = false;
            }
            if (i == 2 && !event2I)
            {
                InactiveEvents = EventsInactiveWitch2;
                event2I = true;
                b = false;
            }
            if (i == 3 && !event3I)
            {
                InactiveEvents = EventsInactiveWitch3;
                event3I = true;
                b = false;
            }
            if (!b)
            {
                InactiveEvents.Invoke();
                a++;
                i++;
                Debug.Log(a);
            }

        yield return null;
    }

    IEnumerator killplayer()
    {
        kill.Kill();
        yield return new WaitForSeconds(0);
    }
}
