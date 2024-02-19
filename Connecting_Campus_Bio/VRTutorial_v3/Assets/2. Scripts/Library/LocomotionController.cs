using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    [SerializeField]
    private ActionBasedController leftTeleportRay;
    [SerializeField]
    private ActionBasedController rightTeleportRay;

    [SerializeField]
    private float teleportActivationThreshold = 0.1f;


    public bool EnableLeftTeleport { get; set; } = true;

    public bool EnableRightTeleport { get; set; } = true;

    // Update is called once per frame
    void Update()
    {
        if (leftTeleportRay)
        {
            leftTeleportRay.gameObject.SetActive(EnableLeftTeleport && CheckIfActivated(leftTeleportRay));
        }

        if (rightTeleportRay)
        {
            rightTeleportRay.gameObject.SetActive(EnableRightTeleport && CheckIfActivated(rightTeleportRay));
        }

    }

    private bool CheckIfActivated(ActionBasedController controller)
    {

        float value = controller.selectAction.action.ReadValue<float>();

        return (value > teleportActivationThreshold);


    }

}
