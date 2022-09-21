using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Executes the fire ability");
        // Execute fire ability
    }
}
