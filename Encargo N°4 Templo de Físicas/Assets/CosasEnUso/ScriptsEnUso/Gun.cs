using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public Transform puntero;
    private float fireRate = 1;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= fireRate)
        {
            if(Input.GetButton("Fire1"))
            {
                timer = 0f;
                FireGun();
            }

        }
    }

    private void FireGun()
    {
        Instantiate(bullet, puntero.position, transform.rotation);

    }
}
