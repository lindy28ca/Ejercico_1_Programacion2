using System;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(PlayerInput))]

public class InputReader : MonoBehaviour
{
    public static event Action<Vector2> Move;
    public static event Action Attac;
    public void MoveEnemy(InputAction.CallbackContext context)
    {
        Move?.Invoke(context.ReadValue<Vector2>());
    }
    public void Attackone(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Attac?.Invoke();
        }
    }
}
