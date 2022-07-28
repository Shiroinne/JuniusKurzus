using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowardsFunctions : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float target = 10;
    [SerializeField] float start;

    [SerializeField] Vector3 targetV = Vector3.one;
    [SerializeField] Vector3 startV;

    [SerializeField] Quaternion targetQ = Quaternion.identity;
    [SerializeField] Quaternion startQ;

    void Update()
    {
        start = Mathf.MoveTowards(start, target, speed * Time.deltaTime);
        startV = Vector3.MoveTowards(startV, targetV, speed * Time.deltaTime);
        startQ = Quaternion.RotateTowards(startQ, targetQ, speed * Time.deltaTime);
    } 
}
