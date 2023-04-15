using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.EntityFolder
{
    public class ScrZombie : ScrCreature
    {
        //Health
        [SerializeField] public float health;
        [SerializeField] public float maxHealth = 30f;

        public override string GetName()
        {
            return "The zombie " + entityData.entityName;
        }
    }
}