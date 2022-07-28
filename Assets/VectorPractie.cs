using UnityEngine;

public class VectorPractie : MonoBehaviour
{
    [SerializeField] Vector2 myFirst2DVector;

    [SerializeField] Vector3 myFirst3DVector;
    [SerializeField] Vector3 mySecond3DVector;
    [SerializeField] float multiplier;

    [SerializeField] Vector3 summa;
    [SerializeField] Vector3 diference;
    [SerializeField] Vector3 product;
    [SerializeField] float lenght;
    [SerializeField] Vector2 normalised;

    void OnValidate()
    {
        //Összeadás 
        summa = myFirst3DVector + mySecond3DVector;

        //Kivonas 
        diference = myFirst3DVector - mySecond3DVector;
         
        //Szorzat 
        product = myFirst3DVector * multiplier;

        // Vektor hossza
        lenght = myFirst2DVector.magnitude;

        // Normalizalt
        normalised = myFirst2DVector.normalized;

        // Egyes komponensek elerese
        float x = myFirst3DVector.x;
        float y = myFirst3DVector.y;
        float z = myFirst3DVector.z;

        // Vektorok letrehozasa
        Vector3 vector3LocalVariable = new Vector3(1, 2, 3);
        Vector2 vector2LocalVariable = new Vector2(1, 2);
    }
}
