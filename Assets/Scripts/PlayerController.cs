using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Light Flashlight;
    [SerializeField] BoxCollider FlashCollider;
    [SerializeField] AudioSource FlashlightSound;
    Animator animator;
    public bool IsAtaking = false;

    bool CanPlay = true;

    Transform TransformPlayer;
    void Start()
    {
        FlashCollider.enabled = false;
        animator = gameObject.GetComponent<Animator>();
        TransformPlayer = gameObject.GetComponent<Transform>();
    }

    
    void Update()
    {
        if (CanPlay)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("Left", true);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("Right", true);
            }

            LightController();
        }
    }

    void LightController()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FlashlightSound.Play();
            Flashlight.intensity = 1;
            FlashCollider.enabled = true;
            IsAtaking = true;
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            FlashlightSound.Play();
            Flashlight.intensity = 0;
            FlashCollider.enabled = false;
            IsAtaking = false;
        }
    }

   void desactiveRotate()
    {
        animator.SetBool("Right", false);
        animator.SetBool("Left", false);
    }

    public void ActivarCanPlay()
    {
        CanPlay = true;
    }
    public void DesactivarCanPlay()
    {
        CanPlay = false;
    }
}
