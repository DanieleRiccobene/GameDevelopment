using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buggy : GroundEnemy
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Sono lo start di buggy");
    }
}
