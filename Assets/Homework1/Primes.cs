using UnityEngine;

public class Primes : MonoBehaviour
{

    void Start()
    {
        int count = 0;
        int number = 2;
        while(count < 100)
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

            if (isPime) 
            {
                Debug.Log(number);
                count++;
            }
            number++;
        }
    }
}
