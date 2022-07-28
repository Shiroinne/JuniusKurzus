using UnityEngine;

public class Rotator2 : MonoBehaviour
{
    [SerializeField] Vector3 axis;
    [SerializeField] float angularSpeed;
    [SerializeField] bool positiveDirection;

    // float angle;

    void Update()
    {
        float dir;
        if (positiveDirection)
            dir = 1;
        else
            dir = -1;

        // Felteteles ertekadas:
        // float dir = positiveDirection ? 1 : -1;



        // angle += dir * angularSpeed * Time.deltaTime;
        // transform.rotation = Quaternion.AngleAxis(angle, axis);



        transform.Rotate(axis, dir * angularSpeed * Time.deltaTime);

    }
}
