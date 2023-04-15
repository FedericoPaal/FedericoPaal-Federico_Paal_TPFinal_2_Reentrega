using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ChrisMovement : MonoBehaviour
{
    //Animator 
    [SerializeField] private Animator anim;
    
    private float x, y;

    //Speeds
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;

    //GameObjects
    [SerializeField] private GameObject pistol;

    //Scripts
    [SerializeField] private Shoot shootScript;
    [SerializeField] private ActivateWeapons activateWeaponsScript;

    [SerializeField] private bool hasTheGun;


    //Take the Gun and Shooting State
    public void OnTriggerEnter(Collider other)
    {
        hasTheGun = false;

         if (other.tag == "Gun")
         {
            hasTheGun = true;
         }

         if (hasTheGun)
        {
            anim.SetBool("Have Gun", true);
        }

         else
        {
            anim.SetBool("Have Gun", false);
        }
    }

    //Is shooting
    public void Shooting()
    {
        RaycastHit hit;
        if (Physics.Raycast(pistol.transform.position, pistol.transform.forward, out hit))
        {
            if (hit.collider.tag == "Zombie")
            {
                shootScript.ShootBullet();
            }
        }
    }


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //Movement without Gun
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate( 0, x * Time.deltaTime * rotationSpeed, 0 );
        transform.Translate( 0, 0 , y * Time.deltaTime * movementSpeed );

        anim.SetFloat("SpeedX", x);
        anim.SetFloat("SpeedY", y);

        //Also movement but with Gun
        if (hasTheGun)
        {
            if (Input.GetMouseButtonDown(0))
            {
                shootScript.ShootBullet();
            }
        }
        

    }
}
 