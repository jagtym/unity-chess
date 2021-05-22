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

}
