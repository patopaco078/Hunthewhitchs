using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainController : MonoBehaviour
{
    Vector3 pos;
    Vector3 inicialPos;
    bool IsClose = false;
    float Timer;
    float velocity;

    [SerializeField] GlobalEventController globalEventController;
    
    private void Start()
    {
        Timer = globalEventController.ActiveTime;
        pos = gameObject.GetComponent<Transform>().localPosition;
        inicialPos = gameObject.GetComponent<Transform>().localPosition;
        velocity = (float)(inicialPos.y-0.43)/ Timer;
    }

    private void Update()
    {
        Timer = globalEventController.ActiveTime;
        velocity = (float)(inicialPos.y - 0.43) / Timer;

        if (IsClose)
        {
            if(pos.y > 0.43)
                pos.y -= Time.deltaTime * velocity;
            gameObject.GetComponent<Transform>().localPosition = pos;
        }
        else
        {
            gameObject.GetComponent<Transform>().localPosition = inicialPos;
            pos = inicialPos;
        }
            
    }

    //-----------------Funciones----------------------

    public void ActiveClose()
    {
        IsClose = true;
    }
    public void DesactiveClose()
    {
        IsClose = false;
        Timer = globalEventController.ActiveTime;
    }
}
