using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private Transform bottomLeft;
    [SerializeField] private int squareSize;
    private Piece[,] boardActiveState;
    private const int BOARD_SIZE = 8;

    public void Awake()
    {
        boardActiveState = new Piece[BOARD_SIZE, BOARD_SIZE];
    }

    public Vector3 GetPositionXandY(Vector2Int coordinates)
    {
        return new Vector3(bottomLeft.position.x + coordinates.x * squareSize, bottomLeft.position.y, bottomLeft.position.z + coordinates.y * squareSize);
    }

    public void SetPieceOnBoard(Piece piece)
    {
        boardActiveState[piece.currentPosition.x, piece.currentPosition.y] = piece;
    }

}