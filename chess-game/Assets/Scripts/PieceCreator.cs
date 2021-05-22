using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PieceCreator: MonoBehaviour
{
    [SerializeField] GameObject[] piecePrefabs;
    [SerializeField] Material whiteMaterial;
    [SerializeField] Material blackMaterial;


    public GameObject CreatePiece(PieceType type)
    {
        foreach (GameObject piecePrefab in piecePrefabs)
        {
            if (piecePrefab.name.ToString() == type.ToString())
            {
                GameObject piece = Instantiate(piecePrefab);
                return piece;
            }
        }
        return null;
    }

    public Material GetMaterial(TeamColor color)
    {
        if (color.ToString() == "White")
        {
            return whiteMaterial;
        }
        return blackMaterial;
    }
}
