using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Plataformas : MonoBehaviour
{
    public Transform theTransform, refIzq, refDer;
    public Transform target;
    public float speed = 3;
    private void Start()
    {
        target = refDer;
    }
    private void Update()
    {
        if (Vector3.Distance(theTransform.position, target.position) > 0.1f)
        {
            theTransform.position = Vector3.MoveTowards(theTransform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            if (target == refDer)
            {
                target = refIzq;
            }
            else if (target == refIzq)
            {
                target = refDer;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = null;
        }
    }
}
