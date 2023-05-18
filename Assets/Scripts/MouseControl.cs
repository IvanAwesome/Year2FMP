using UnityEngine;

public class MouseControl : MonoBehaviour
{
    private void Start()
    {
        // Lock and hide the cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void Update()
    {
        // Check if the Escape key is pressed to regain mouse control
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Unlock and show the cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}