using System;
using UnityEngine;

public class Duck : MonoBehaviour
{
    private Input _input;
    private Renderer _renderer;
    private Collider _collider;

    private void Awake()
    {
        _input = GetComponent<Input>();
        _renderer = GetComponent<MeshRenderer>();
        _collider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Vehicle"))
        {
            Die();
        }
    }

    private void Die()
    {
        _input.StopDuck();
        gameObject.SetActive(false);
    }
}
