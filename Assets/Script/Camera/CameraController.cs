using UnityEngine;

public class CameraController : MonoBehaviour // Inherit from MonoBehaviour
{
    [Header("Target")]
    public Transform target; // The player to follow

    [Header("Offset")]
    public Vector3 offset = new Vector3(0, 0, -10f); // Ensure the camera stays behind

    [Header("Follow Settings")]
    public float smoothSpeed = 5f; // Adjust for smoothness

    void LateUpdate()
    {
        if (target != null)
        {
            // Desired position is player's position + offset
            Vector3 desiredPosition = target.position + offset;
            
            // Smooth the camera movement
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            transform.position = smoothedPosition;
        }
    }
}