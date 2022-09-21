using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private KeyCode WaterAbilityKey;
    [SerializeField] private KeyCode EarthAbilityKey;
    [SerializeField] private KeyCode FireAbilityKey;
    [SerializeField] private KeyCode AirAbilityKey;

    private InputHandler inputHandler = new InputHandler();

    private void Awake()
    {
        inputHandler.BindInput(WaterAbilityKey, new WaterCommand());
        inputHandler.BindInput(EarthAbilityKey, new EarthCommand());
        inputHandler.BindInput(FireAbilityKey, new FireCommand());
        inputHandler.BindInput(AirAbilityKey, new AirCommand());
    }

    private void Update()
    {
        inputHandler.HandleInput();
    }
}
