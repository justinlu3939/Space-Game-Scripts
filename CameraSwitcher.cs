using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera; // Reference to your main camera
    public Camera additionalCamera; // Reference to the additional camera
    private bool isMainCameraActive = true; // Flag to track which camera is active

    public Button switchCams;
    void Start()
    {
        mainCamera.enabled = true;
        additionalCamera.enabled = false;
        switchCams.onClick.AddListener(BackCameraSwitch);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            BackCameraSwitch();
        }
    }

    void BackCameraSwitch()
    {
        // Toggle between cameras
        isMainCameraActive = !isMainCameraActive;
        mainCamera.enabled = isMainCameraActive;
        additionalCamera.enabled = !isMainCameraActive;
    }
}
