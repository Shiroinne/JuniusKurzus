using UnityEngine;

class Circle : MonoBehaviour
{
    [SerializeField] float radius;

    [SerializeField] float circumferance; // Kerulet
    [SerializeField] float area;          // Terulet

    // float pi = 3.14f;

    void OnValidate()
    {

        circumferance = 2 * radius * Mathf.PI;
        area = radius * radius * Mathf.PI;
    }
}
