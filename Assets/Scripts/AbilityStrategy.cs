using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class AbilityStrategy : ScriptableObject
{
    public abstract void UseAbility(Transform desiredPosition, Quaternion desiredRotation);
}