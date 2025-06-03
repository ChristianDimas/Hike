using UnityEngine;

public class CameraController : MonoBehaviour // Inherit from MonoBehaviour
{
    [Header("Target")]
    public Transform target; // The player to follow

    [Header("Offset")]
    public Vector3 offset = new Vector3(0, 0, -10f); // Ensure the camera stays behind

    [Header("Follow Settings")]
    public float smoothSpeed = 5f; // Adjust for smoothness

    [Header("Pixel Perfect Settings")]
    public float pixelsPerUnit = 16f; // Match your PPU setting

    void LateUpdate()
    {
        if (target != null)
        {
            // Desired position is player's position + offset
            Vector3 desiredPosition = target.position + offset;

            // Smooth the camera movement
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            // Snap the camera position to the pixel grid
            Vector3 snappedPosition = new Vector3(
                Mathf.Round(smoothedPosition.x * pixelsPerUnit) / pixelsPerUnit,
                Mathf.Round(smoothedPosition.y * pixelsPerUnit) / pixelsPerUnit,
                smoothedPosition.z // Z-axis remains unchanged
            );

            transform.position = snappedPosition;
        }
    }
}