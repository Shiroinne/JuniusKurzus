using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3 center;
    [SerializeField] float radius;
    [SerializeField] float angularSpeed;

    float angle;

    void Update()
    {
        angle += angularSpeed * Time.deltaTime;

        float angleInRad = angle * Mathf.Deg2Rad;
        Vector3 pos = new Vector3(
            Mathf.Sin(angleInRad),0,Mathf.Cos(angleInRad));
        pos *= radius;
        pos += center;

        transform.position = pos;
    }
}
