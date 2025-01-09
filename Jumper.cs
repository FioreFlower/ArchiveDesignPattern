using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 점프만 하는 캐릭터
public class Jumper : Character
{
    public override void Doing()
    {
        textMesh.text = "점프만";
        PlayJumpAnimation();
    }
    
}
