using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private Vector3 speed;

    private IObjectPool<Projectile> projectilePool;

    private void Update()
    {
        transform.position += speed * Time.deltaTime;
    }

    // When the projectile leaves the screen, release it from the projectilepool
    private void OnBecameInvisible()
    {
        projectilePool.Release(this);
    }

    public void SetPool(IObjectPool<Projectile> _projectilePool)
    {
        projectilePool = _projectilePool;
    }
}
