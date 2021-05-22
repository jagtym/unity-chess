using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MaterialSetter))]
public abstract class Piece : MonoBehaviour
{
    private Vector2Int currentPosition;
    private TeamColor team;
    private Board board;
    private MaterialSetter materialSetter
    {
        get
        {
            return GetComponent<MaterialSetter>();
        }
    }

    public void SetParameters(Vector2Int position, TeamColor team)
    {
        currentPosition = position;
        this.team = team;
    }

    public void SetMaterial(Material material)
    {
        materialSetter.SetMaterial(material);
    }
}

