using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.EntityFolder
{
    public class ScrCreature : ScrEntity
    {
        public override string GetName()
        {
            return "The creature " + entityData.entityName;
        }
    }
}