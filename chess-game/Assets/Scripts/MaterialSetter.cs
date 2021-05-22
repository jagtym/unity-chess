using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MaterialSetter : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;

    public void SetMaterial(Material material)
    {
        meshRenderer.material = material;
    }
}
