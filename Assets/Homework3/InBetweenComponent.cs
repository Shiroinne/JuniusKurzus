using UnityEngine;

[ExecuteInEditMode]
public class InBetweenComponent : MonoBehaviour
{
    [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField] Color colorA;
    [SerializeField] Color colorB;
    [SerializeField] float targetPosition;
    [SerializeField] float changeSpeed;

    float pos;

    void Start()
    {
        pos = targetPosition;
    }

    void Update()
    { 
        pos = Mathf.MoveTowards(
            pos,targetPosition, 
            changeSpeed * Time.deltaTime);

        if (a == null || b == null)
            return;

        transform.position =
            Vector3.Lerp(a.position, b.position, pos);
    }

    void OnDrawGizmos()
    {
        float r = 0.25f;

        Gizmos.color = colorA;
        Gizmos.DrawWireSphere(a.position, r);
        Gizmos.color = colorB;
        Gizmos.DrawWireSphere(b.position, r);

        Gizmos.color = Color.Lerp(colorA, colorB, pos);
        Gizmos.DrawLine(a.position, b.position);
    }
}
