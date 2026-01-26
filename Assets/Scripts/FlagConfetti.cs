using UnityEngine;

public class FlagConfetti : MonoBehaviour
{
    public GameObject confettiPrefab;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(confettiPrefab, transform.position, Quaternion.identity);
        }
    }
}
