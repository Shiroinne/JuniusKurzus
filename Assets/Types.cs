using UnityEngine;

public class Types : MonoBehaviour
{
    void Start()
    {
        int i = 3;                  // Integer numbers
        float f = 3.5f;             // Fraction numbers
        string s = "Some Text";     // Text
        bool b1 = true;
        bool b2 = false;            // True or False

        Debug.Log(i);
        Debug.Log(f);
        Debug.Log(s);
        Debug.Log(b1);
        Debug.Log(b2);

        var v = 3.5f;
        int v2 = (int) v;           // casting

        // i = 3, f = 3.5
        int p1 = i * (int)f;        // 9
        int p2 = (int)(i * f);      // 10

        var v3 = 5;
        float v4 = v3;              // implicit casting

        var sss = s + i;   // Some Text3

        var sss2 = s + i + f;   // ???
        var sss3 = i + f + s;   // ???
        var sss4 = i + s + f;   // ???
    }
}
