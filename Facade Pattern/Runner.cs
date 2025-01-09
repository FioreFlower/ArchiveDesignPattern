using UnityEngine;

public class Runner : Character
{
    public override void Doing()
    {
        textMesh.text = "달리기만";
        Debug.Log("Runner: 달리기 시작!");
        PlayRunAnimation();
    }
}