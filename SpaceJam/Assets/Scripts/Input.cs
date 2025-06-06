using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


public class KeyboardInput : MonoBehaviour
{
    public void OnEngine(InputAction.CallbackContext context)
    {
        Debug.Log("Engine action triggered: " + context.action.name);
        Debug.Log($"Interaction type: {context.interaction.ToString()}");
    }

    public void OnRotation(InputAction.CallbackContext context)
    {
        Debug.Log("Rotation action triggered: " + context.action.name);
        Debug.Log($"Interaction type: {context.interaction.ToString()}");
    }
}
