using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private InputHandler inputHandler = new InputHandler();

    private void Awake()
    {
        inputHandler.BindInput(KeyCode.Q, new WaterCommand());
        inputHandler.BindInput(KeyCode.W, new EarthCommand());
        inputHandler.BindInput(KeyCode.E, new FireCommand());
        inputHandler.BindInput(KeyCode.R, new AirCommand());
    }

    private void Update()
    {
        inputHandler.HandleInput();
    }
}
