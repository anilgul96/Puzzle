using System.Collections.Generic;
using UnityEngine;

public class SpawnTiles : MonoBehaviour
{
    [SerializeField] List<GameObject> tiles = new List<GameObject>();
    public void TrySpawnTilesOnBoard(int i, int j)
    {
        var generatedTiles = Instantiate(tiles[Random.Range(0, tiles.Count)], new Vector2(i,j), Quaternion.identity);
    }
}
