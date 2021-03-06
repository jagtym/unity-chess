using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PieceCreator))]
[RequireComponent(typeof(Board))]

public class GameController : MonoBehaviour
{   
    [SerializeField] private StartingLayout layout;
    private Board chessBoard;
    private PieceCreator creator;

    public void Start()
    {
        creator = GetComponent<PieceCreator>();
        chessBoard = GetComponent<Board>(); 
        InitializeBoard();
    }

    public void InitializeBoard()
    {
        for (int i = 0; i < layout.GetPieceCount(); i++)
        {
            Vector2Int position = layout.GetSquareCoordinates(i);
            PieceType type = layout.GetSquarePieceType(i);
            TeamColor color = layout.GetSquarePieceColor(i);

            Piece piece = creator.CreatePiece(type).GetComponent<Piece>();
            if (piece != null)
            {
                piece.SetParameters(position, color, chessBoard);
                piece.SetMaterial(creator.GetMaterial(color));

                if (color == TeamColor.Black)
                {
                    piece.RotatePiece();
                }
            }
        }
    }

    


}
