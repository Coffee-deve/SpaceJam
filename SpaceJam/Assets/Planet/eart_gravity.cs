using UnityEngine;

public class eart_gravity : MonoBehaviour
{

    public Rigidbody2D body;
    public GameObject obj;

    public Rocket rocketObj;

    public static void AddGravityForce(Rigidbody2D attractor, Rigidbody2D target)
    {
        float G = 1.0f;
        float massProduct = attractor.mass * target.mass * G;
        Vector3 difference = attractor.position - target.position;
        float distance = difference.magnitude;
        float unScaledforceMagnitude = massProduct / Mathf.Pow(distance, 2);
        float forceMagnitude = G * unScaledforceMagnitude;
        Vector3 forceDirection = difference.normalized;
        Vector3 forceVector = forceDirection * forceMagnitude;
        target.AddForce(forceVector);
    }

    void Start()
    {
        
    }

    void Update()
    {
        AddGravityForce(body, rocketObj.body);
    }
}
