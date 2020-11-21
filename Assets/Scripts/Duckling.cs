using UnityEngine;

public class Duckling : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Vehicle"))
        {
            gameObject.SetActive(false);
        }
    }
}
