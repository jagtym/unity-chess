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
    private Player currentPlayer;
    private Player whitePlayer;
    private Player blackPlayer;

    public void Start()
    {
        creator = GetComponent<PieceCreator>();
        chessBoard = GetComponent<Board>();
        InitializePlayers();
        InitializeBoard();
    }

    private void InitializePlayers()
    {
        whitePlayer = new Player(TeamColor.White, chessBoard);
        blackPlayer = new Player(TeamColor.Black, chessBoard);
        currentPlayer = whitePlayer;
    }

    public void InitializeBoard()
    {
        for (int i = 0; i < layout.GetPieceCount(); i++)
        {
            Vector2Int position = layout.GetSquareCoordinates(i);
            PieceType type = layout.GetSquarePieceType(i);
            TeamColor color = layout.GetSquarePieceColor(i);

            Piece piece = creator.CreatePiece(type).GetComponent<Piece>();
            
            InitializePiece(position, color, piece);
        }
        LoadInitializedPieces();
    }

    private void LoadInitializedPieces()
    {
        whitePlayer.LoadPlayerPiecesOntoBoard();
        blackPlayer.LoadPlayerPiecesOntoBoard();
    }

    private void InitializePiece(Vector2Int position, TeamColor color, Piece piece)
    {
        if (piece != null)
        {
            piece.SetParameters(position, color, chessBoard);
            piece.SetMaterial(creator.GetMaterial(color));

            if (color == TeamColor.White)
            {
                whitePlayer.AddPiece(piece);
            }
            else if (color == TeamColor.Black)
            {
                piece.RotatePiece();
                blackPlayer.AddPiece(piece);
            }
        }
    }



}
