using UnityEngine;

class OwnLerp : MonoBehaviour
{
    [SerializeField] float a, b, t;

    [Space]
    [SerializeField] float lerpUnclamped;
    [SerializeField] float mathfLerpUnclamped;

    [Space]
    [SerializeField] float lerp;
    [SerializeField] float mathfLerp;


    void OnValidate()
    {
        lerpUnclamped = LerpUnclamped(a, b, t);
        mathfLerpUnclamped = Mathf.LerpUnclamped(a, b, t);
        lerp = Lerp(a, b, t);
        mathfLerp = Mathf.Lerp(a, b, t);
    }

    float LerpUnclamped(float a, float b, float t) 
    {
        float dif = b - a;
        return t * (b - a) + a;
    }

    float Lerp(float a, float b, float t)
    {
        float lerpUnclamped = LerpUnclamped(a, b, t);

        float min = Mathf.Min(a, b);
        float max = a > b ? a : b;

        return Mathf.Clamp(lerpUnclamped, min, max);
    }

}
