using UnityEngine;

public class CharacterMover
{
    public void OnForward()
    {
        Debug.Log("Forward character");
    }
    
    public void OnBackward()
    {
        Debug.Log("Backward character");
    }

    public void OnIdle()
    {
        Debug.Log("Idle character");
    }

    public void OnUndo(CharacterState prevCommand)
    {
        switch (prevCommand)
        {
            case CharacterState.Backward:
                OnBackward();
                break;
            case CharacterState.Forward:
                OnForward();
                break;
            case CharacterState.Idle:
                OnIdle();
                break;
        }
    }
}