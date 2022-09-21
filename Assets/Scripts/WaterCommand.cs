using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCommand : ICommand
{
    private ProjectileLauncher projectileLauncher;
    private Projectile projectile;
    private int ID = 1;

    public WaterCommand(ProjectileLauncher _projectileLauncher, Projectile _projectile)
    {
        projectileLauncher = _projectileLauncher;
        projectile = _projectile;
    }

    public void Execute()
    {
        WaterAbility();
    }

    private void WaterAbility()
    {
        Debug.Log("Executes the water ability");
        projectileLauncher.StartProjectile(projectile, ID);
    }
}
