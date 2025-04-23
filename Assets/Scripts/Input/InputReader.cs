using System;
using UnityEngine.InputSystem;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public static event Action<Vector2> Move;
    public static event Action Attac;
    public static event Action Habilidad;
    public void MoveEnemy(InputAction.CallbackContext context)
    {
        Move?.Invoke(context.ReadValue<Vector2>());
    }
    public void Attackone(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Attac?.Invoke();
        }
        if (context.performed)
        {
            Habilidad?.Invoke();
        }
    }
}s