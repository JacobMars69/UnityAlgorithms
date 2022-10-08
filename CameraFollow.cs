using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    public float speed;

    void LateUpdate()
    {
        Vector3 targetPosition = target.transform.position + offset;
        Vector3 currentPosition = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        transform.position = currentPosition;
    }
}