using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private float startPosition;
    public GameObject camera;
    public float parallaxEffect = 0.5f; // The speed at which the background should move relative to the camera

    void Start()
    {
        startPosition = transform.position.x;
    }

    void FixedUpdate()
    {
        // Calculate background distance based on camera movement
        float distance = camera.transform.position.x * parallaxEffect; // 0 - 1 range

        transform.position = new Vector3(startPosition + distance, transform.position.y, transform.position.z);
    }
}
