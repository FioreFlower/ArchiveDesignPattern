using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public Character Jumper;
    public Character Runner;
    public Character DelayedRunner;
    
    // Start is called before the first frame update
    void Start()
    {
        Jumper.Doing();
        Runner.Doing();
        DelayedRunner.Doing();
    }
    
}
