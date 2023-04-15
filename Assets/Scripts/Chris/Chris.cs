using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Assets.Scripts.Inheritance_Scripts;
using UnityEngine.Events;

public class Chris : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float m_health;

    [SerializeField] public ScrChris scrChris;
    [SerializeField] ChrisUIController chrisUIControllerScipt;

    [SerializeField] HealthBar healthBarScript;

    private HealthController m_healthController;

    //Takes Damage
    public void PlayerTakeDamage(int damageAmount)
    {
        scrChris.health -= damageAmount * Time.deltaTime;
        GameManager.gameManager._entyHealth.DamageUnit(damageAmount);
        healthBarScript.SetHealth(GameManager.gameManager._entyHealth.Health);

        

        if (scrChris.health <= 0)
        {
            Destroy(gameObject);
            OnDeath?.Invoke();
        }
    }

    //Events
    public Action OnChrisMoved;
    public UnityEvent OnDeath;
    

    public HealthController GetHealthController() 
    {
        return m_healthController; 
    
    }

        private void Awake()
    {
        m_healthController = new HealthController(m_health);
        
    }

    private void Start()
    {
        scrChris.health = scrChris.maxHealth;
    }

    private void Update()
    {
        Move(GetMoveVector());
        Rotate(GetRotationAmount());
    }

    //Movement
    private void Move(Vector3 moveDir)
    {
        var transform1 = transform;
        transform1.position +=
            (moveDir.x * transform1.right + moveDir.z * transform1.forward) * (speed * Time.deltaTime);

        var l_isMoving = moveDir != Vector3.zero;
        
        if(l_isMoving)
        {
            OnChrisMoved?.Invoke();
        }
    }

    //Rotation
    private void Rotate(float rotateAmount)
    {
        transform.Rotate(Vector3.up, rotateAmount * Time.deltaTime * rotationSpeed, Space.Self);

    }

    private float GetRotationAmount()
    {
        return Input.GetAxis("Mouse X");
    }
    private Vector3 GetMoveVector()
    {
        var l_horizontal = Input.GetAxisRaw("Horizontal");
        var l_vertical = Input.GetAxisRaw("Vertical");

        return new Vector3(x: l_horizontal, y: 0, z: l_vertical).normalized;
    }

    public float GetCurrentHealth()
    {
        return m_healthController.GetCurrentHealth();
    }

}


public class HealthController
{
    private float m_currentHealth;
    private float m_maxHealth;

    public Action<float> OnHealthChange;
    

    public HealthController(float p_maxhealth)
    {
        m_maxHealth = p_maxhealth;
        m_currentHealth = p_maxhealth;

    }

    public float GetCurrentHealth()
    {
        return m_currentHealth;
    }


    public void ReceiveDamage(float p_currentDamage)
    {
        m_currentHealth -= p_currentDamage;

        OnHealthChange?.Invoke(m_currentHealth);

    }
    

}