using System;
using UnityEngine;

public class RemoteControl : MonoBehaviour
{
    private CommandMethodBase commandMethod;
    private CommandMethodBase prevCommandMethod;
    
    public void SetCommand(CharacterState state)
    {
        if (commandMethod != null) prevCommandMethod = commandMethod;
        commandMethod = state switch
        {
            CharacterState.Idle => new IdleCommandMethod(),
            CharacterState.Forward => new ForwardCommandMethod(),
            CharacterState.Backward => new BackwardCommandMethod(),
        };
    }
    
    public void PressButton()
    {
        if (commandMethod != null)
            commandMethod.Execute();
        else
        {
            Debug.Log("No command selected");
        }
    }

    public void PressUndo()
    {
        if (commandMethod == null) return;
        commandMethod.Undo(prevCommandMethod); 
        commandMethod = prevCommandMethod;
    }
}