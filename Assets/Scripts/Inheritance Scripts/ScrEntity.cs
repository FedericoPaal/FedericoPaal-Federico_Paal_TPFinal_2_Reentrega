using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrEntity : MonoBehaviour
{
    [SerializeField] protected EntityDATA entityData;

    public virtual string GetName()
    {
        return entityData.entityName;
    }



}
