using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    public Rocket rocket;

    public Vector3 cameraOffset = new Vector3(0, -10, 0);

    public float smooth = 0.5f;

    void Start()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 _targetPosition = new Vector3(rocket.transform.position.x,
            rocket.transform.position.y,
            transform.position.z) + cameraOffset;

        transform.position = Vector3.Lerp(transform.position, _targetPosition, smooth * rocket.body.linearVelocity.magnitude * Time.deltaTime);
    }
}