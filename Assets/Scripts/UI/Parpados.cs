using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parpados : MonoBehaviour
{
    [SerializeField] Transform ParpadoSuperior;
    [SerializeField] Transform ParpadoInferior;

    public bool CerrarOjos = false;
    [SerializeField] float velocity = 300;
    [SerializeField] Vector3 Pos_S;
    [SerializeField] Vector3 Pos_I;
    private void Start()
    {
        Pos_S = ParpadoSuperior.localPosition;
        Pos_I = ParpadoInferior.localPosition;
    }

    private void Update()
    {
        if (CerrarOjos)
        {
            if(Pos_S.y > 10)
            {
                Pos_S.y -= Time.deltaTime * velocity;
                Pos_I.y += Time.deltaTime * velocity;
                ParpadoSuperior.localPosition = Pos_S;
                ParpadoInferior.localPosition = Pos_I;
            }
        }
        else
        {
            if (Pos_S.y < 373)
            {
                Pos_S.y += Time.deltaTime * velocity;
                Pos_I.y -= Time.deltaTime * velocity;
                ParpadoSuperior.localPosition = Pos_S;
                ParpadoInferior.localPosition = Pos_I;
            }
        }
    }
}
