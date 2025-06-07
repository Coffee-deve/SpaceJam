using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket : MonoBehaviour
{

    public float enginePower = 0;
    public float G = 9.81f;
    public float engineDirection = 0; // Angle in degrees
    public Rigidbody2D body;
    public GameObject obj;
   // public Earth earth;
    public Vector2 newSize; // Width and height in scale units

    public Vector2 DegreeToVector(float angle)
    {
        // Convert angle in degrees to radians
        float radian = angle * Mathf.Deg2Rad;
        // Calculate the x and y components
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian));
    }
    
    void Start()
    {
        // setting up the size
        transform.localScale = new Vector3(newSize.x, newSize.y, 1f);

    }

    void Update()
    {
        obj.transform.rotation = Quaternion.Euler(0, 0, engineDirection - 90);
        body.AddForce(DegreeToVector(engineDirection) * enginePower * Time.deltaTime);
    }
}
