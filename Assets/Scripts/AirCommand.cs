using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCommand : ICommand
{
    private ProjectileLauncher projectileLauncher;
    private Projectile projectile;
    private int ID = 4;

    public AirCommand(ProjectileLauncher _projectileLauncher, Projectile _projectile)
    {
        projectileLauncher = _projectileLauncher;
        projectile = _projectile;
    }

    public void Execute()
    {
        AirAbility();
    }

    private void AirAbility()
    {
        Debug.Log("Executes the air ability");
        projectileLauncher.StartProjectile(projectile, ID);
    }
}
