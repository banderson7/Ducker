using UnityEngine;

public class Input : MonoBehaviour
{
    private Controls _controls;
    private Movement _movement;

    private void Awake()
    {
        _controls = new Controls();
        _movement = GetComponent<Movement>();
    }
    private void Start()
    {
        _controls.Duck.Move.performed += ctx => _movement.MoveInput(ctx.ReadValue<Vector2>());
        _controls.Duck.Move.canceled += ctx => _movement.MoveInput(ctx.ReadValue<Vector2>());
        
        _controls.Duck.Enable();
    }

    public void StopDuck()
    {
        _controls.Duck.Disable();
    }
}
