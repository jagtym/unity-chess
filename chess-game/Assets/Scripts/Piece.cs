using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MaterialSetter))]
public abstract class Piece : MonoBehaviour
{
    internal Vector2Int currentPosition { get; private set; }
    private TeamColor team;
    private Board board;
    private MaterialSetter materialSetter
    {
        get
        {
            return GetComponent<MaterialSetter>();
        }
    }

    public void SetParameters(Vector2Int position, TeamColor team, Board board)
    {
        currentPosition = position;
        this.team = team;
        this.board = board;
        Vector3 calculatedPosition = board.GetPositionXandY(currentPosition);
        transform.position = calculatedPosition;
    }

    public void RotatePiece()
    {
        transform.Rotate(0, -180, 0, Space.Self);
    }

    public void SetMaterial(Material material)
    {
        materialSetter.SetMaterial(material);
    }
}

