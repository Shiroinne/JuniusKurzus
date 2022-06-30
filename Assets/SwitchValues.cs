using UnityEngine;

public class SwitchValues : MonoBehaviour
{
    [SerializeField] string num1;
    [SerializeField] string num2;

    void Start()
    {
        // Megcserel
        string t = num1;
        num1 = num2;
        num2 = t;
    }

}
