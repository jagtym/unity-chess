using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/StartingLayout")]
public class StartingLayout : ScriptableObject
{
    [Serializable]
    private class SquareSetup 
    {
        public Vector2Int position;
        public TeamColor teamColor;
        public PieceType pieceType;
    }

    [SerializeField] private SquareSetup[] squares;

    public Vector2Int GetSquareCoordinates(int index)
    {
        return squares[index].position;
    }

    public PieceType GetSquarePieceType(int index)
    {
        return squares[index].pieceType;
    }

    public TeamColor GetSquarePieceColor(int index)
    {
        return squares[index].teamColor;
    }

    public int GetPieceCount() 
    {
        return squares.Length;
    }

}
