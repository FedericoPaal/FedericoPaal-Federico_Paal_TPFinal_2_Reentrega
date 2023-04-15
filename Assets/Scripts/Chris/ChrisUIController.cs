using Assets.Scripts.Inheritance_Scripts;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChrisUIController : MonoBehaviour
{

    [SerializeField] private Slider healthBar;

    [SerializeField] private Chris m_chrisController;
    [SerializeField] private Zombie z_zombieAdvise;

    private ScrChris scrChrisScript;
    private Chris chrisScript;

    private Animator anim;

    private void Start()
    {
        //scrChrisScript.health = scrChrisScript.maxHealth;
        //healthBar.value = scrChrisScript.health;
        //healthBar.maxValue = scrChrisScript.maxHealth;

        anim = GetComponent<Animator>();


        var l_healthController = m_chrisController.GetHealthController();
        //l_healthController.OnHealthChange += UpdateHealthBarUI;

        m_chrisController.OnChrisMoved += UpdateItMoved;

        var c_healthController = m_chrisController.GetHealthController(); 
        //c_healthController.OnHealthChange += UpdateChrishasDied;
    }

    

    public void UpdateHealthBarUI()
    {
        if (scrChrisScript.health >= 0)
        {
            chrisScript.PlayerTakeDamage(10);
        }
        //scrChrisScript.health -= dmgValue;
        //healthBar.value = scrChrisScript.health;
    }

    private void Update()
    {


    }



    public void UpdateItMoved()
    {
        Debug.Log("Chris is moving");
    }

    public void UpdateChrishasDied()
    {

        Debug.Log("You have died");
    }
    public void UpdateItIsAproaching()
    {
            Debug.Log("Zombie is aproaching to you");   
    }

    public void UpdateItIsAttacking()
    {
        Debug.Log("Zombie is attacking to you");
    }

    public void UpdateOnHealthChange()
    {
        Debug.Log("Chris is losing health");
    }
}
