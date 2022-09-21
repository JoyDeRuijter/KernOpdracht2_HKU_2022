using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AAbility : ScriptableObject, IAbility
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private float speed;

    public abstract void Use(Character character);
}
