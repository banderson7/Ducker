using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    private float _forwardInput;
    private float _turnInput;
    private Transform _myTransform;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
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
        _animator.SetBool("Walking", true);
    }

    private void Turn()
    {
        _myTransform.Rotate(_myTransform.up * (_turnInput * turnSpeed * Time.deltaTime));
        _animator.SetBool("Walking", true);
    }

    private void Update()
    {
        if (_forwardInput > 0)
            ForwardMovement();
        
        Turn();
        
        if (_forwardInput <= 0 && _turnInput == 0)
            _animator.SetBool("Walking", false);
    }
}
