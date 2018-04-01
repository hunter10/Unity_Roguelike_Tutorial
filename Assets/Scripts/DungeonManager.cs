using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public enum TileType
{
    essential,
    random,
    empty
}

public class DungeonManager : MonoBehaviour {

    // 각 PathTile은 해당 타일에 인접한 타일을 계산해 알아낸다.
    [Serializable]
    public class PathTile
    {
        public TileType type;
        public Vector2 position;
        public List<Vector2> adjacentPathTiles;

        public PathTile(string t, Vector2 p, int min, int max, Dictionary<Vector2, TileType> currentTiles)
        {
            type = (TileType)System.Enum.Parse(typeof(TileType), t);
            position = p;
            adjacentPathTiles = getAdjacentPath(min, max, currentTiles);
        }

        public List<Vector2> getAdjacentPath(int minBound, int maxBound, Dictionary<Vector2, TileType> currentTiles)
        {
            List<Vector2> pathTiles = new List<Vector2>();

            return pathTiles;
        }
    }
	
}
