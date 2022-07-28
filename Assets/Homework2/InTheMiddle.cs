using UnityEngine;

public class InTheMiddle : MonoBehaviour
{
    [SerializeField] Transform t1;
    [SerializeField] Transform t2;

    void Update()
    {
        Vector3 average = 
            (t1.position + t2.position) / 2;
        transform.position = average;


    }
}
