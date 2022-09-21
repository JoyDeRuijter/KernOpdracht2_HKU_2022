using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private KeyCode WaterAbilityKey;
    [SerializeField] private KeyCode EarthAbilityKey;
    [SerializeField] private KeyCode FireAbilityKey;
    [SerializeField] private KeyCode AirAbilityKey;

    private Projectile waterProjectile, earthProjectile, fireProjectile, airProjectile;

    private ProjectileLauncher launcher;
    private InputHandler inputHandler = new InputHandler();

    private void Awake()
    {
        launcher = GetComponent<ProjectileLauncher>();

        LoadProjectiles();
        BindAllKeys();
    }

    private void Update()
    {
        inputHandler.HandleInput();
    }

    private void LoadProjectiles()
    {
        waterProjectile = (Resources.Load("WaterProjectile") as GameObject).GetComponent<Projectile>();
        earthProjectile = (Resources.Load("EarthProjectile") as GameObject).GetComponent<Projectile>();
        fireProjectile = (Resources.Load("FireProjectile") as GameObject).GetComponent<Projectile>();
        airProjectile = (Resources.Load("AirProjectile") as GameObject).GetComponent<Projectile>();
    }

    private void BindAllKeys()
    {
        inputHandler.BindInput(WaterAbilityKey,
        new WaterCommand(launcher, waterProjectile));
        inputHandler.BindInput(EarthAbilityKey,
            new EarthCommand(launcher, earthProjectile));
        inputHandler.BindInput(FireAbilityKey,
            new FireCommand(launcher, fireProjectile));
        inputHandler.BindInput(AirAbilityKey,
            new AirCommand(launcher, airProjectile));
    }
}
