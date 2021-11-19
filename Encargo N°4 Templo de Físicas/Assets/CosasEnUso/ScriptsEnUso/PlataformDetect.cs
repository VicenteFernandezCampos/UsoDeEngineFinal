using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformDetect : MonoBehaviour
{
    public float speed = 5;
    public GameObject plataforma;
    public Transform movePlat;
    bool bulletDetect;


    
    void Start()
    {
        
    }

    

    void Update()
    {
        if(bulletDetect)
        {
            plataforma.transform.position = Vector3.MoveTowards(plataforma.transform.position, movePlat.position, speed*Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            bulletDetect = true;
        }
    }
}
