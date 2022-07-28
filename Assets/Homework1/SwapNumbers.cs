using UnityEngine;

public class SwapNumbers : MonoBehaviour
{
    [SerializeField] int a;  // 3
    [SerializeField] int b;  // 8

    void Start()
    {
        a += b;     // 11
        b = a - b;  // 3
        a = a - b;  // 8
    }
}
