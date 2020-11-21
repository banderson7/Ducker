using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 _offset;

    private void Awake()
    {
        _offset = transform.position - target.transform.position;
    }

    private void Update()
    {
        transform.position = target.position + _offset;
    }
}
