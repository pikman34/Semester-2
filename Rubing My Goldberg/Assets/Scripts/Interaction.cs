using System;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.Events;

public class InteractionScript : MonoBehaviour
{
    public UnityEvent enteredTrigger, exitedTrigger, interacted;

    private bool insideTrigger;

    void Update()
    {
        if (insideTrigger && Input.GetKeyDown(KeyCode.D))
        {
            interacted.Invoke();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        enteredTrigger.Invoke();
        insideTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        exitedTrigger.Invoke();
        insideTrigger = false;
    }




}