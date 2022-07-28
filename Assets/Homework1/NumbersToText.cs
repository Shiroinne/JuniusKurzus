using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersToText : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string text;

    void OnValidate()
    {
        text = "";
        for (int i = 1; i <= number; i++)
        {
            if (i < number)            
                text = text + i + ", ";            
            else            
                text = text + i;            
        }
    }
}
