using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public float minY = -0.5f;
    public float maxY = 2f;

    void FixedUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Please assign a target object to the CameraFollow script.");
            return;
        }

        // Calculate the desired y-position, clamped to the specified range
        float desiredY = Mathf.Clamp(target.position.y, minY, maxY);

        // Smoothly move the camera to the desired y-position
        float currentY = transform.position.y;
        float newY = Mathf.Lerp(currentY, desiredY, smoothSpeed);

        // Set the camera's position, keeping the x and z coordinates fixed
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}