using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    [SerializeField] protected Projectile projectile;
    [SerializeField] protected float speed;
    [SerializeField] protected float damage;
    
    protected ProjectileLauncher launcher;

    private void Awake()
    {
        launcher = FindObjectOfType<ProjectileLauncher>();
    }

    protected virtual void Use()
    {
        launcher.StartProjectile(projectile);
    }
}
