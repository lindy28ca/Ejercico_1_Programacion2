using UnityEngine;
using UnityEngine.Rendering;
[RequireComponent (typeof(Rigidbody2D))]
abstract public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 move;
    [Header("Characteristics")]
    [SerializeField] private float velocity;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D> ();

    }
    private void FixedUpdate()
    {
        rb2d.linearVelocity = move;
    }
    private void Move(Vector2 value)
    {
        move = value*velocity;
    }
    protected abstract void Attac();
    private void OnEnable()
    {
        InputReader.Move += Move;
        InputReader.Attac += Attac;
    }
    private void OnDisable()
    {
        InputReader.Move += Move;
        InputReader.Attac += Attac;
    }

}
