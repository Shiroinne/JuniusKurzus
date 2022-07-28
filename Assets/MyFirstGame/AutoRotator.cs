using UnityEngine;

class AutoRotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;

    void Update()
    {
        transform.Rotate(
            Vector3.up,
            angularSpeed * Time.deltaTime,
            Space.World);
    }
}
