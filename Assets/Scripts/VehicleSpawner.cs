using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public GameObject car;
    public Transform spawnPoint;
    public float spawnTimer;
    public bool rightToLeft;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        Quaternion rotation = Quaternion.identity;
        if (rightToLeft)
            rotation = spawnPoint.rotation * Quaternion.Euler(0f, 180f, 0f);
        Instantiate(car, spawnPoint.position, rotation);
        yield return new WaitForSeconds(spawnTimer);
        StartCoroutine(Spawn());
    }
}
