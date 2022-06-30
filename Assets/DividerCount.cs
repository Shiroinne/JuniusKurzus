using UnityEngine;

class DividerCount : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] int countOfDeviders;

    void OnValidate()
    {
        countOfDeviders = 0;

        for (int i = 1; i < num;i++) 
        {
            bool isDevidable = num % i == 0;
            if (isDevidable)
            {
                countOfDeviders++;
            }
        }
    }
}
