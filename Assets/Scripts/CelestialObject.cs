using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CelestialObject : MonoBehaviour
{
    protected float sizeMin, sizeMax;
    public float rotateSelfSpeed;
    public List<Material> materials;

    protected virtual void Start()
    {
        SetMaterial();
        SetSize();
    }

    protected virtual void Update()
    {
        RotateSelf();
    }

    public abstract void Move();

    public virtual void RotateSelf()
    {
        transform.Rotate(Vector3.up * rotateSelfSpeed * Time.deltaTime, Space.Self);
    }
    public virtual void SetMaterial()
    {
        GetComponent<MeshRenderer>().material = materials[Random.Range(0, materials.Count)];
    }
    public virtual void SetSize()
    {
        float scaleFactor = Random.Range(sizeMin, sizeMax);
        transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }

}
