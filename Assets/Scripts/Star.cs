using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : CelestialObject
{
    override protected void Start()
    {
        sizeMin = 5f;
        sizeMax = 7f;
        base.Start();
    }

    public override void Move()
    {

    }
}
