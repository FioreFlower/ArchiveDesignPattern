using UnityEngine;

public class DelayedRunner : Character
{
    public override void Doing()
    {
        textMesh.text = "일단 점프 후 3초 뒤 달리기!";
        PlayJumpAnimation();
        StartCoroutine(DelayForSecond(3f));
        textMesh.text = "달리기 시작";
        PlayRunAnimation();
    }
}