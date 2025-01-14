using System;
using UnityEngine;

public class CharacterClient : MonoBehaviour
{
    private ICommand characterMoverForward = new ForwardCommand();
    private ICommand characterMoverBackward = new BackwardCommand();
    private ICommand characterMoverIdle = new IdleCommand();

    private RemoteControl remote;

    private CharacterState currentCharacterState;
    private CharacterState prevCharacterState;

    public void Start()
    {
        remote = gameObject.AddComponent<RemoteControl>();
        currentCharacterState = CharacterState.Idle;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            remote.SetCommand(GetCurrentCommand(CharacterState.Backward));
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            remote.SetCommand(GetCurrentCommand(CharacterState.Forward));
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            remote.SetCommand(GetCurrentCommand(CharacterState.Idle));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            remote.PressButton();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            remote.PressUndo(prevCharacterState);
        }
    }
    
    private ICommand GetCurrentCommand(CharacterState characterState)
    {
        prevCharacterState = currentCharacterState;
        currentCharacterState = characterState;
        
        return currentCharacterState switch
        {
            CharacterState.Idle => characterMoverIdle,
            CharacterState.Forward => characterMoverForward,
            CharacterState.Backward => characterMoverBackward,
        };
    }
}