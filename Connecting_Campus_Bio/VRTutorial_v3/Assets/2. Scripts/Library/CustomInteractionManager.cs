using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class CustomInteractionManager : MonoBehaviour
{
    

    public void HandleHoverEnter(HoverEnterEventArgs args)
    {
        if(args.interactableObject.transform.CompareTag("Enemy"))
        {
            Debug.Log("Hover over enemy");
        }
    }
    public void HandleSelectEnter(SelectEnterEventArgs args)
    {
      /*  if (args.interactableObject.transform.CompareTag("Enemy"))
        {
            args.interactableObject.transform.localScale *= 0.5f;

        }*/
    }
    public void HandleActivateEnter(ActivateEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("Enemy"))
        {
            Debug.Log("Activating enemy");
            Transform t = args.interactableObject.transform;
            args.interactableObject.transform.localRotation = Quaternion.Euler(0, t.localEulerAngles.y, 0);
        }
    }
}
