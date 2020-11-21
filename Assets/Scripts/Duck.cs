using System;
using UnityEngine;

public class Duck : MonoBehaviour
{
    private Input _input;

    private void Awake()
    {
        _input = GetComponent<Input>();
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
