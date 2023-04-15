using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   

    void Start()
    {

    }

    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.TryGetComponent<Zombie>(out Zombie zombieComponent))
        {
            zombieComponent.TakeDamage(10);

        }
        Destroy(gameObject);
    }
}
