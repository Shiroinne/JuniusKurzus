using UnityEngine;

public class PrimesWithMethods : MonoBehaviour
{
    void Start()
    {
        int count = 0;
        int number = 2;

        if (number == 0)
            return;

        while(count < 100)
        {
            bool isPime = IsPrime(number);

            if (isPime) 
            {
                Debug.Log(number);
                count++;
            }
            number++;
        }
    }

    bool IsPrime(float number) 
    {
        bool isPime = true;
        if (number < 2)
            isPime = false;
        else
        {
            for (int i = 2; i < number; i++)
            {
                bool d = number % i == 0;
                if (d)
                    isPime = false;
            }
        }
        return isPime;
    }
}
