using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
   
    public UnityEvent theEvent;
    public virtual void Interact()
    {
        theEvent.Invoke();
    }
}
