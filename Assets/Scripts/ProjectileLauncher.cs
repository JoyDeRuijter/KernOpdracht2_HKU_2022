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

    public void StartProjectile(Projectile _projectile, int _ID)
    {
        lastProjectileID = currentProjectileID;
        currentProjectileID = _ID;
        if (currentProjectileID != lastProjectileID)
            projectilePool.Clear();

        projectilePrefab = _projectile;
        projectilePool.Get();
    }

    private Projectile CreateProjectile()
    { 
        Projectile projectile = Instantiate(projectilePrefab, this.transform);
        projectile.SetPool(projectilePool);
        return projectile;
    }

    private void OnGet(Projectile _projectile)
    { 
        _projectile.gameObject.SetActive(true);
        _projectile.transform.position = transform.position;
    }

    private void OnRelease(Projectile _projectile)
    {
        _projectile.gameObject.SetActive(false);
    }

    private void OnDelete(Projectile projectile)
    {
        Destroy(projectile.gameObject);
    }
}
