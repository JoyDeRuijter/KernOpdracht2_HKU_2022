using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AAbility : ScriptableObject, IAbility
{
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected float speed;
    [SerializeField] protected float damage;

    private void OnEnable()
    {
        projectile.GetComponent<Projectile>().Speed = speed;
        projectile.GetComponent<Projectile>().Damage = damage;
    }

    public abstract void Use(Character character);
}
