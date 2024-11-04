using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FruitAnimationController : MonoBehaviour
{
    private Animator animator;
    private CharacterController controller;
    public UnityEvent triggerEvent;

    private void Start()
    {
        // Cache the Animator component attached to CharacterArt
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        OnTriggerAnimate();
    }

    private void OnTriggerAnimate()
    {
        triggerEvent.Invoke();
        animator.SetTrigger("PickUp");
    }
}