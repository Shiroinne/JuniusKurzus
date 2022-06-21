using UnityEngine;

public class Variables : MonoBehaviour
{
    // Full Line Comment
    void Start()
    {
        /* Inline Comment */

        /* 
        Multiple 
        Line
        Comment
        */

        int myFirstVariable; // Declaration
        myFirstVariable = 5; // Definition

        Debug.Log(myFirstVariable);
        myFirstVariable = 7; // Set new value
        Debug.Log(myFirstVariable);

        // int a, b, c; // Declaration of multiple variables

        int secondVarible = 3; // Declaration & Definition in 1 line
        Debug.Log(secondVarible);

        // Declaration & Definition of multiple variables
        int x = 3, y = 7, z = -1;
        y = 22;

        int summa = x + y + z;
        Debug.Log(summa);

        int product = x * y * z * 2;
        Debug.Log(product);

        int dif = x - y;
        Debug.Log(dif);

        int rate = x / y;
        Debug.Log(rate);

        int negated = -x;
        Debug.Log(negated);

        int modulo = x % y;
        Debug.Log(modulo);
    }
}
