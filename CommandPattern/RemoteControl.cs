using UnityEngine;

public class RemoteControl : MonoBehaviour
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }
    
    public void PressButton()
    {
        _command.Execute(); // 명령 실행
    }

    public void PressUndo(CharacterState currentCommand)
    {
        _command.Undo(currentCommand); // 명령 취소
    }
}