using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource audioSource; 

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newPulia = Instantiate(bullet, transform.position, transform.rotation);
            newPulia.GetComponent<Rigidbody>().velocity = transform.forward * 25f;
            audioSource.Play();
        }
    }
}
