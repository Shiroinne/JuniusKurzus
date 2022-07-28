using UnityEngine;

class MethodPractice : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float abs;
    [SerializeField] float power;

    void OnValidate()
    {
        min = Minimum(a, b);
        max = Mathf.Max(a, b);
        abs = Mathf.Abs(a);
        power = Mathf.Pow(a, b);
    }

    float Minimum(float n1, float n2)
    {
        float min;
        if (n1 < n2)
        {
            min = n1;
        }
        else
        {
            min = n2;
        }
        return min;
    }

    float MinimumV2(float n1, float n2)
    {
        if (n1 < n2)
            return n1;
        else
            return n2;
    }

    float Abs(float n) 
    {
        if (n < 0)
            return -n;
        
        return n;
    }
}
