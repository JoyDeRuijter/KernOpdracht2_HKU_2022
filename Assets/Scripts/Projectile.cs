using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float damage;
    public float Damage
    { 
        get { return damage; }
        set { damage = value; }
    }

    private float speed;
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    private void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        transform.position += newPosition * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
