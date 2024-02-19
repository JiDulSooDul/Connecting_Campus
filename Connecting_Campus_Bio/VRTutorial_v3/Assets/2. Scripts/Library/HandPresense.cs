using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresense : MonoBehaviour
{

    private InputDevice targetDevice;

    [SerializeField]
    private GameObject controllerPrefab;

    private GameObject spawnedController;


    [SerializeField]
    private InputDeviceCharacteristics deviceCharacteristics;

    // show controller or not?
    [SerializeField]
    private bool showController = false;

    [SerializeField]
    private GameObject handPrefab;

    private GameObject spawnedHand;

    private Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        InitializeInput();


    }

    private void InitializeInput()
    {
        // list all connected XR devices
        List<InputDevice> devices = new List<InputDevice>();


        InputDevices.GetDevicesWithCharacteristics(deviceCharacteristics, devices);

        /*        foreach(InputDevice dev in devices){
                    Debug.Log(dev.name + ", " + dev.characteristics);
                }*/

        if (devices.Count > 0)
        {
            targetDevice = devices[0];

            if (controllerPrefab)
            {
                spawnedController = Instantiate(controllerPrefab, transform);
            }
        }

        // spawn hand model
        if (spawnedHand == null)
        {
            spawnedHand = Instantiate(handPrefab, transform);
            handAnimator = spawnedHand.GetComponent<Animator>();
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (!targetDevice.isValid)
        {
            InitializeInput();
            return;
        }

        // show/hide hand / controller
        spawnedHand.SetActive(!showController);
        spawnedController.SetActive(showController);

        if (!showController)
        {
            // update the animation
            UpdateHandAnimation();
        }


        //    testInput();

    }

    private void UpdateHandAnimation()
    {
        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            handAnimator.SetFloat("Trigger", triggerValue);

        }
        else
        {
            handAnimator.SetFloat("Trigger", 0); // couldn't get trigger value
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grip", gripValue);

        }
        else
        {
            handAnimator.SetFloat("Grip", 0); // couldn't get trigger value
        }

    }
    private void testInput()
    {

        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        {
            Debug.Log("Primary button (A) pressed");
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.2f)
        {
            Debug.Log("Trigger was pressed more than 20%");
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger) && trigger)
        {
            Debug.Log("Trigger was pressed");
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 movement) && movement != Vector2.zero)
        {
            Debug.Log("Joystick moved: " + movement);
        }


    }

}