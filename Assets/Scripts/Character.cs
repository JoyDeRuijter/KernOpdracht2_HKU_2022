using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private KeyCode waterAbilityKey = KeyCode.Q;
    [SerializeField] private KeyCode earthAbilityKey = KeyCode.W;
    [SerializeField] private KeyCode fireAbilityKey = KeyCode.E;
    [SerializeField] private KeyCode airAbilityKey = KeyCode.R;

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

    // Load the projectile prefabs from the Resources folder
    private void LoadProjectiles()
    {
        waterProjectile = (Resources.Load("WaterProjectile") as GameObject).GetComponent<Projectile>();
        earthProjectile = (Resources.Load("EarthProjectile") as GameObject).GetComponent<Projectile>();
        fireProjectile = (Resources.Load("FireProjectile") as GameObject).GetComponent<Projectile>();
        airProjectile = (Resources.Load("AirProjectile") as GameObject).GetComponent<Projectile>();
    }

    // Bind all commands to the chosen keys
    private void BindAllKeys()
    {
        inputHandler.BindInput(waterAbilityKey,
            new WaterCommand(launcher, waterProjectile));
        inputHandler.BindInput(earthAbilityKey,
            new EarthCommand(launcher, earthProjectile));
        inputHandler.BindInput(fireAbilityKey,
            new FireCommand(launcher, fireProjectile));
        inputHandler.BindInput(airAbilityKey,
            new AirCommand(launcher, airProjectile));
    }
}
