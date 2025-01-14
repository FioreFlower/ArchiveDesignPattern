public interface ICommand 
{
    void Execute();  // 명령 실행
    void Undo(CharacterState prevCommand);     // 명령 취소
}
