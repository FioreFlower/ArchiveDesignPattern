public class BackwardCommand : ICommand
{
    private CharacterMover mover = new CharacterMover();
    
    public void Execute()
    {
        mover.OnBackward();
    }

    public void Undo(CharacterState prevCommend)
    {
        mover.OnUndo(prevCommend);
    }
}