using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class dog : XRGrabInteractable
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Destroyer()
    {
        animator.Play("asd");
        Destroy(gameObject,3f);
    }
}
