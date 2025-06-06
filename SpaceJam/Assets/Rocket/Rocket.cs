using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket : MonoBehaviour

{

    public float force = 2f;
    public Rigidbody2D myRigidbody;
    public GameObject myBody;
    public Vector2 newSize = new Vector2(2f, 2f); // Width and height in scale units

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // setting up the size
        transform.localScale = new Vector3(newSize.x, newSize.y, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            force = force + 0.1f;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            force = force - 0.1f;
        }
        myRigidbody.AddForce(Vector2.up * force * Time.deltaTime);
    }
}
