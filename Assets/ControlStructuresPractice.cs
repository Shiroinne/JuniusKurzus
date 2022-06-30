using UnityEngine;

public class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int a = 3;
    [SerializeField] int b = 5;


    [SerializeField] int n = 5;
    void Start()
    {
        // Selection / elagazas
        bool aIsGreaterThanB = a > b;
        if (a > b)
        {
            Debug.Log("A is Greater than B");
        }
        else
            Debug.Log("A is NOT Greater than B");

        // Loop / ciklus
        int i = 3;
        int count = 0;
        while (count < n) 
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
                count++;
            }
            i = i + 1;
        }

        for (int j = 0; j < n; j++)
        {
            Debug.Log(i * 3);
        }


    }
}
