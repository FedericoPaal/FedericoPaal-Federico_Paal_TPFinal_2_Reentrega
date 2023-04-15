using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class RaycastLaser : MonoBehaviour
{
    //private LineRenderer laserLine;
    public float range = 15f;
    public GameObject pointOfShoot;
    private void Start()
    {
        //laserLine = GetComponent<LineRenderer>();
        
        
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            if (Physics.Raycast(pointOfShoot.transform.position, pointOfShoot.transform.forward, out hit, range))
            {
                    Debug.Log(hit.collider.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(pointOfShoot.transform.position, pointOfShoot.transform.forward * range);
    }



}
