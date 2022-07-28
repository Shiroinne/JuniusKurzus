using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] KeyCode rightKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;

    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;

    [SerializeField] Damageable damageable;

    void OnValidate()
    {
        if (damageable == null)
            damageable = GetComponent<Damageable>();
    }

    void Update()
    {
        if (damageable != null && damageable.health <= 0)
            return;

        bool right = Input.GetKey(rightKey);
        bool left = Input.GetKey(leftKey);
        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);

        float x = ToAxis(right, left);
        float z = ToAxis(up, down);

        Vector3 velocity = new Vector3(x, 0, z);

        transform.position += velocity.normalized * speed * Time.deltaTime;
                
        if (velocity != Vector3.zero) 
        {
            Quaternion targetRotation = Quaternion.LookRotation(velocity);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotationSpeed * Time.deltaTime);
        }
    }

    float ToAxis(bool positive, bool negative) 
    {
        float value;
        if (positive)
            value = 1;
        else if (negative)
            value = -1;
        else
            value = 0;
        return value;
    }
}
