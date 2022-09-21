using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthCommand : ICommand
{
    private ProjectileLauncher projectileLauncher;
    private Projectile projectile;
    private int ID = 2;

    public EarthCommand(ProjectileLauncher _projectileLauncher, Projectile _projectile)
    {
        projectileLauncher = _projectileLauncher;
        projectile = _projectile;
    }

    public void Execute()
    {
        EarthAbility();
    }

    private void EarthAbility()
    {
        Debug.Log("Executes the earth ability");
        projectileLauncher.StartProjectile(projectile, ID);
    }
}
