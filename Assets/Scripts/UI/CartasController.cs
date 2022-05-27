using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartasController : MonoBehaviour
{
    public bool Oryx = false;
    public bool Xya = false;
    public bool Hanah = false;
    public bool Anie = false;

    bool isEnable = true; //-474
    bool KeyDown = false;
    bool isUp = false;

    [SerializeField] GameObject UiButtons;
    [SerializeField] Vector3 pos;

    private void Start()
    {
        pos = UiButtons.GetComponent<Transform>().localPosition;
        UiButtons.GetComponent<AudioSource>().enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && isEnable)
        {
            KeyDown = true;
        }
        if(KeyDown && isEnable && isUp)
        {
            DownUI();
        }
        if (KeyDown && isEnable && !isUp)
        {
            UpUI();
        }
        if (!isEnable)
        {
            DownUI();
        }
    }

    void DownUI()
    {
        if (isUp)
        {
            Debug.Log("a");
            UiButtons.GetComponent<AudioSource>().enabled = true;
            pos.y -= Time.deltaTime * 800;
            UiButtons.GetComponent<Transform>().localPosition = pos;
            if (pos.y < -474)
            {
                KeyDown = false;
                isUp = false;
                UiButtons.GetComponent<AudioSource>().enabled = false;
            }
        }
    }
    void UpUI()
    {
        if (!isUp)
        {
            Debug.Log("b");
            UiButtons.GetComponent<AudioSource>().enabled = true;
            pos.y += Time.deltaTime * 800;
            UiButtons.GetComponent<Transform>().localPosition = pos;
            if (pos.y > 0)
            {
                KeyDown = false;
                isUp = true;
                UiButtons.GetComponent<AudioSource>().enabled = false;
            }
        }
    }
    public void IsOryx_A()
    {
        Oryx = true;
        isEnable = false;
    }

    public void IsXya()
    {
        Xya = true;
        isEnable = false;
    }

    public void IsHanah()
    {
        Hanah = true;
        isEnable = false;
    }

    public void IsAnie()
    {
        Anie = true;
        isEnable = false;
    }

    public void ActiveEnable()
    {
        isEnable = true;
    }
    public void DesactiveEnable()
    {
        isEnable = false;
    }

    public void AllFalseButton()
    {
        Oryx = false;
        Xya = false;
        Hanah = false;
        Anie = false;
        isEnable = true;
    }
}
