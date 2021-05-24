using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private List<Piece> alivePieces;
    private TeamColor team;
    private Board board;

    public Player(TeamColor team, Board board)
    {
        this.team = team;
        this.board = board;
        alivePieces = new List<Piece>();
    }

    public void AddPiece(Piece addedPiece)
    {
            alivePieces.Add(addedPiece);
    }

    public void LoadPlayerPiecesOntoBoard()
    {
        foreach (Piece piece in alivePieces) {
            board.SetPieceOnBoard(piece);
        }
    }

    public bool IsFromTheSameTeam(Piece piece)
    {
        if (piece.team == team)
        {
            return true;
        }
        return false;
    }
}
