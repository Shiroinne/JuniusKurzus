using UnityEngine;

class Collector : MonoBehaviour
{
    int collectedValue;

    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = 
            other.GetComponent<Collectable>();

        if (collectable != null) 
        {
            collectedValue += collectable.value;
            Debug.Log($"Collected: {collectable.value}, All: {collectedValue}");

            collectable.Collect();
        }
    }
}
