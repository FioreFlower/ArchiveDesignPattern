using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleCommand : ICommand
{
    private CharacterMover mover = new CharacterMover();
    
    public void Execute()
    {
        mover.OnIdle();
    }

    public void Undo(CharacterState prevCommand)
    {
        mover.OnUndo(prevCommand);
    }
}
