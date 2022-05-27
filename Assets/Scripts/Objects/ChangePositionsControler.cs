using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionsControler : MonoBehaviour
{
    [SerializeField] Transform Book;
    [SerializeField] Transform Casset;
    [SerializeField] Transform wineglass;

    Vector3 bookC = new Vector3(-0.644f, 0.327456f, 0.320189f);
    Vector3 CassetC = new Vector3(-1.15f, 0.293f, -0.002f);
    Vector3 WineglassC = new Vector3(-1.042f, 0.327456f, 0.414f);

    public void ChangePosition()
    {
        Book.localPosition = bookC;
        Casset.localPosition = CassetC;
        wineglass.localPosition = WineglassC;
    }
}
