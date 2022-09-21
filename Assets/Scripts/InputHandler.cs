using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    private List<KeyCommand> keyCommands = new List<KeyCommand>();

    public void HandleInput() 
    {
        foreach (KeyCommand kc in keyCommands)
            if (Input.GetKeyDown(kc.key))
                kc.command.Execute();
    }

    public void BindInput(KeyCode _keyCode, ICommand _command)
    {
        keyCommands.Add(new KeyCommand()
        {
            key = _keyCode,
            command = _command
        });
    }

    public void UnbindInput(KeyCode _keyCode)
    { 
        foreach (KeyCommand kc in keyCommands)
            if (kc.key == _keyCode)
                keyCommands.Remove(kc);
    }
}
