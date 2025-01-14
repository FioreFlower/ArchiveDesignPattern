using UnityEngine;

public partial class CharacterClient : MonoBehaviour
{
    ICommand characterMoverForward = new ForwardCommand();
    ICommand characterMoverBackward = new BackwardCommand();
    ICommand characterMoverIdle = new IdleCommand();

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
            remote.SetCommand(characterMoverBackward);
            prevCharacterState = currentCharacterState;
            currentCharacterState = CharacterState.Backward;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            remote.SetCommand(characterMoverForward);
            prevCharacterState = currentCharacterState;
            currentCharacterState = CharacterState.Forward;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            remote.SetCommand(characterMoverIdle);
            prevCharacterState = currentCharacterState;
            currentCharacterState = CharacterState.Idle;
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
}