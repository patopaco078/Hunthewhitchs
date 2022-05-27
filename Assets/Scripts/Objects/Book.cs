using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Book : MonoBehaviour
{
    [SerializeField] Sprite Write;
    bool s;

    private void Update()
    {
        if (s)
        {
            writing();
        }
    }

    void writing()
    {
        gameObject.GetComponent<MeshRenderer>().materials[2].SetTexture("_MainTex", Write.texture);
        gameObject.GetComponent<MeshRenderer>().materials[2].SetColor("_Color", Color.white);
    }

    public void ActiveBook()
    {
        s = true;
    }
}
