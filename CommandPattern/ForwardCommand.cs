using UnityEngine;

public class ForwardCommand : MonoBehaviour, ICommand
{
    private CharacterMover mover = new CharacterMover();
    
    public void Execute()
    {
        mover.OnForward();
    }

    public void Undo(CharacterState prevCommand)
    {
        mover.OnUndo(prevCommand);
    }

    
}