using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : CelestialObject
{
    public GameObject centerObject;
    private float speed;

    // Start is called before the first frame update
    override protected void Start()
    {
        sizeMin = -0.8f;
        sizeMax = 1f;
        speed = Random.Range(10f, 25f);
        base.Start();
    }

    // Update is called once per frame
    override protected void Update()
    {
        Move();
        base.Update();
    }

    public override void Move()
    {
        transform.RotateAround(centerObject.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
