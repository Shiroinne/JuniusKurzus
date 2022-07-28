using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    [SerializeField] int number;
    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            bool dividableWith3 = i % 3 == 0;
            bool dividableWith5 = i % 5 == 0;
            bool dividableWith3And5 = dividableWith3 && dividableWith5;
            
            if (dividableWith3And5)
                Debug.Log("fizzbuzz");
            else if (dividableWith3) 
            {
                Debug.Log("fizz");            
            }
            else if (dividableWith5)
                Debug.Log("buzz"); 
            else
                Debug.Log(i);

        }
    }
}
