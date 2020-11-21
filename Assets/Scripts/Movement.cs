using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    private float _forwardInput;
    private float _turnInput;
    private Transform _myTransform;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _myTransform = transform;
    }
    public void MoveInput(Vector2 input)
    {
        _forwardInput = input.y;
        _turnInput = input.x;
    }

    private void ForwardMovement()
    {
        _myTransform.position += _myTransform.forward * (_forwardInput * speed * Time.deltaTime);
    }

    private void Turn()
    {
        _myTransform.Rotate(_myTransform.up * (_turnInput * turnSpeed * Time.deltaTime));
    }

    private void Update()
    {
        if (_forwardInput > 0)
            ForwardMovement();

        Turn();
    }
}
