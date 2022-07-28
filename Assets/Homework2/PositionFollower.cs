using UnityEngine;

public class PositionFollower : MonoBehaviour
{
    [SerializeField] Transform followable;
    [SerializeField] AnimationCurve speedOverDistance;
    [SerializeField] float regenerateSpeed;

    [SerializeField, Range(0, 100)] float startStamina = 1;

    float stamina;
    bool regenerating = false;

    private void Start()
    {
        stamina = startStamina;
    }

    void Update()
    {
        if (followable == null)
            return;

        if (regenerating)
            Regenerate();
        else
            Move();
    }

    void Regenerate()
    {
        stamina += Time.deltaTime * regenerateSpeed;
        if (stamina >= startStamina)
        {
            regenerating = false;
            stamina = startStamina;
        }
    }

    void Move()
    {
        float distance = Vector3.Distance(followable.position, transform.position);

        float speed = speedOverDistance.Evaluate(distance);

        Vector3 startPos = transform.position;
        transform.position = Vector3.MoveTowards(
                transform.position, followable.position, speed * Time.deltaTime);
        Vector3 endPos = transform.position;

        float step = (endPos - startPos).magnitude;

        Vector3 vectorPointingToTarget = followable.position - transform.position;
        if(vectorPointingToTarget != Vector3.zero)
            transform.rotation = 
                Quaternion.LookRotation(vectorPointingToTarget);

        stamina -= step;

        if (stamina <= 0)
        {
            regenerating = true;
            stamina = Mathf.Max(0, stamina);
        }
    }
}
