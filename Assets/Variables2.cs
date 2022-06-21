using UnityEngine;

public class Variables2 : MonoBehaviour
{
    void Start()
    {
        int a, b, c;

        a = 5;
        b = 3;
        c = a + b;  // 8
        c = 2;      // 2
        Debug.Log(c);

        c += 5;     // c = c + 5;   7
        c -= 3;     // c = c - 3;   4
        c *= 2;     // c = c * 2;   8
        c /= 4;     // c = c / 4;   2
        c++;        // c = c + 1;   3
        ++c;        // c = c + 1;   4
        c--;        // c = c - 1;   3
        --c;        // c = c - 1;   2

        Debug.Log(c);            // 2

        int x = a + b * c;       // 11
        Debug.Log(x);            
        int y = (a + b) * c;     // 16
        Debug.Log(y);            
    }
}
