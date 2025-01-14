using UnityEngine;

public enum CharacterState
{
    None,
    Forward,
    Backward,
    Idle,
    Max
}

public class CharacterActions
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
}