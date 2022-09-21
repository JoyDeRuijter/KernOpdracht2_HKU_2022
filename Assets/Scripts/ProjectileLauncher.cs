using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Pool;

public class ProjectileLauncher : MonoBehaviour
{
    private Projectile projectilePrefab;
    private int currentProjectileID, lastProjectileID;
    private IObjectPool<Projectile> projectilePool;

    private void Awake()
    {
        projectilePool = new ObjectPool<Projectile>(
            CreateProjectile,
            OnGet,
            OnRelease,
            OnDelete,
            maxSize: 8 
            );
    }

    // Receive a projectile and ID through one of the concrete commands
    // Check if the last projectile was different from the current one, if so, clear the pool
    // Set the new projectilePrefab and get the pool
    public void StartProjectile(Projectile _projectile, int _ID)
    {
        lastProjectileID = currentProjectileID;
        currentProjectileID = _ID;
        if (currentProjectileID != lastProjectileID)
            projectilePool.Clear();

        projectilePrefab = _projectile;
        projectilePool.Get();
    }

    // Instantiate a new projectile as child of this launcher and set it to the pool
    private Projectile CreateProjectile()
    { 
        Projectile projectile = Instantiate(projectilePrefab, this.transform);
        projectile.SetPool(projectilePool);
        return projectile;
    }

    // Get a projectile from the pool, reset it's position and set it active again
    private void OnGet(Projectile _projectile)
    { 
        _projectile.gameObject.SetActive(true);
        _projectile.transform.position = transform.position;
    }

    // Set a projectile to inactive
    private void OnRelease(Projectile _projectile)
    {
        _projectile.gameObject.SetActive(false);
    }

    // Destroy a projectile
    private void OnDelete(Projectile projectile)
    {
        Destroy(projectile.gameObject);
    }
}
