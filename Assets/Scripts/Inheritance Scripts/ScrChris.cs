using Assets.Scripts.EntityFolder;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Inheritance_Scripts
{
    public class ScrChris : ScrCreature
    {
        //Health
        [SerializeField] public float health;
        [SerializeField] public float maxHealth = 30f;

        //[SerializeField] private List<Weapons> m_myWeapons;

    }
}
