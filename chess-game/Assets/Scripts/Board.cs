using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private Transform bottomLeft;
    [SerializeField] private int squareSize;

    public Vector3 GetPositionXandY(Vector2Int coordinates)
    {
        return new Vector3(bottomLeft.position.x + coordinates.x * squareSize, bottomLeft.position.y, bottomLeft.position.z + coordinates.y * squareSize);
    }
}
