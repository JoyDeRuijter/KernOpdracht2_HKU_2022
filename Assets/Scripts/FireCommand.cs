using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCommand : ICommand
{
    private ProjectileLauncher projectileLauncher;
    private Projectile projectile;

    public FireCommand(ProjectileLauncher _projectileLauncher, Projectile _projectile)
    {
        projectileLauncher = _projectileLauncher;
        projectile = _projectile;
    }

    public void Execute()
    {
        FireAbility();
    }

    private void FireAbility()
    {
        Debug.Log("Executes the fire ability");
        projectileLauncher.StartProjectile(projectile, 3);
    }
}
