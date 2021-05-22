using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MaterialSetter : MonoBehaviour
{
    private MeshRenderer meshRenderer 
    {
    get
        {
            return GetComponent<MeshRenderer>();
        }    
    }


    public void SetMaterial(Material material)
    {
        meshRenderer.material = material;
    }
}
