using UnityEngine;

public abstract class CommandMethodBase
{
    protected readonly CharacterActions Actions = new();
    public virtual void Execute() {}

    public virtual void Undo(CommandMethodBase prevCommandMethod)
    {
        prevCommandMethod.Execute();
        Debug.Log($"currentCommand: {this.GetType().Name} to {prevCommandMethod.GetType().Name}");
    }
}

public class IdleCommandMethod : CommandMethodBase
{
    public override void Execute() => Actions.OnIdle();
}

public class BackwardCommandMethod : CommandMethodBase
{
    public override void Execute() => Actions.OnBackward();
}

public class ForwardCommandMethod : CommandMethodBase
{
    public override void Execute() => Actions.OnForward();
}