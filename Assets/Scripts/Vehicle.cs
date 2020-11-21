using System;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        Drive();
    }

    private void Drive()
    {
        transform.position += transform.right * (speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Side"))
        {
            Destroy(gameObject);
        }
    }
}
