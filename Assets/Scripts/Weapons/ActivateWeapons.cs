using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWeapons : MonoBehaviour
{
    public TakeWeapon takeWeapon;
    public int weaponNum;

    
    private void Start()
    {
        takeWeapon = GameObject.FindGameObjectWithTag("Player").GetComponent<TakeWeapon>();
    }

    public void OnTriggerEnter(Collider other)
    {   
        //Take Gun from the table
        if (other.tag == "Player")
        {
            takeWeapon.WeaponToActivate(weaponNum);
            Destroy(gameObject);
        }
    }


}
