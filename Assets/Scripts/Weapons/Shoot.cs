using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject pointOfShoot;
    [SerializeField] private float bulletForwardForce;

    public void ShootBullet()
    {
        //When shooting
        GameObject temporaryBulletHandler;
        temporaryBulletHandler = Instantiate(bullet, pointOfShoot.transform.position, pointOfShoot.transform.rotation) as GameObject;

        temporaryBulletHandler.transform.Rotate(Vector3.left * 90);

        Rigidbody temporaryRigidbody;
        temporaryRigidbody= temporaryBulletHandler.GetComponent<Rigidbody>();

        temporaryRigidbody.AddForce(transform.forward * bulletForwardForce);

        Destroy(temporaryBulletHandler, 0.75f);


    }

    private void Start()
    {

    }


    private void Update()
    {
        
    }
}
