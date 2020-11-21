using DefaultNamespace;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour, IFollower
{
    public float followDistance = 2;
    private Transform _target;
    private NavMeshAgent _agent;
    private bool _isFound;

    private void Awake()
    {
        _isFound = false;
        _agent = GetComponent<NavMeshAgent>();
    }

    public void StartFollowing(Transform target)
    {
        _target = target;
        _isFound = true;
    }

    private void Update()
    {
        if (!_isFound) return;
        if (Vector3.Distance(_target.position, transform.position) > followDistance)
        {
            _agent.isStopped = false;
            _agent.SetDestination(_target.position);
        }
        else
        {
            _agent.isStopped = true;
        }
    }
}
