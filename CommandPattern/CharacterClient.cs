using System;
using UnityEngine;

[RequireComponent(typeof(RemoteControl))]
public class CharacterClient : MonoBehaviour
{
    private RemoteControl remote;
    
    private void Update()
    {
        // 상태 변경
        if (Input.GetKeyDown(KeyCode.R)) RunCommand(CharacterState.Backward);
        if (Input.GetKeyDown(KeyCode.F)) RunCommand(CharacterState.Forward);
        if (Input.GetKeyDown(KeyCode.I)) RunCommand(CharacterState.Idle);
        
        // 롤백
        if (Input.GetKeyDown(KeyCode.U)) remote.PressUndo();
    }

    private void RunCommand(CharacterState state)
    {
        remote.SetCommand(state);
        remote.PressButton();
    }
}