using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // Reference to the player transform
    public float sensitivity = 2.0f; // Mouse movement sensitivity
    public Vector2 rotationRange = new Vector2(70, 70); // Range of camera rotation

    private Vector3 offset; // Offset between camera and player
    private float verticalRotation = 0; // Vertical rotation angle

    void Start()
    {
        // Calculate the initial offset between camera and player
        offset = transform.position - player.position;
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor
    }

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotate the player based on horizontal mouse movement
        player.Rotate(Vector3.up * mouseX);

        // Update vertical rotation angle
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -rotationRange.y, rotationRange.y);

        // Rotate the camera around the player vertically
        transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        // Update camera position based on player position
        transform.position = player.position + offset;
    }
}

