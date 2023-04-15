using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore.Text;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] public Animator anim;
    [SerializeField] public Zombie zombieScript;

    [SerializeField] public float movementSpeed = 1f;
    [SerializeField] public float rotationSpeed;

    [SerializeField] public bool isAware;
    


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 20f))
        {
            if (hit.collider)
            {

            }
        }

        OnAware();
    }

    private void OnAware()
    {
        var l_zombieIsClose = zombieScript.closeEnough;
        

        //Set isAware as true
        if (l_zombieIsClose)
        {
            isAware = true;
        }

        else
        {
            isAware = false;
        }

        //Set Aware in animator
        if (isAware)
        {
            anim.SetBool("Aware", true);
        }

        else
        {
            anim.SetBool("Aware", false);
        }
    }





}
