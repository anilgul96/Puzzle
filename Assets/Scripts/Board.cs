using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Board
{
    public class Board : MonoBehaviour
    {
        [SerializeField] List<GameObject> _tiles = new List<GameObject>();
        [SerializeField] int _xAxis = 0;
        [SerializeField] int _yAxis = 0;

        Tile[,] _tileMatrix;
        private void Awake()
        {
            _tileMatrix = new Tile[_xAxis, _yAxis];
        }
        private void Start()
        {
            TryGenerateBoard();
        }

        private void TryGenerateBoard()
        {
            for (int i = 0; i < _xAxis; i++)
            {
                for (int j = 0; j < _yAxis; j++)
                {
                    TrySpawnTilesOnBoard(new Vector2Int(i,j));
                }
            }
        }
        private void TrySpawnTilesOnBoard(Vector2Int coordinate)
        {
            var generatedTiles = Instantiate(_tiles[Random.Range(0, _tiles.Count)], new Vector3Int(coordinate.x, coordinate.y), transform.rotation);
            generatedTiles.transform.parent = transform;
            generatedTiles.transform.localPosition = new Vector3Int(coordinate.x, coordinate.y);
            _tileMatrix[coordinate.x, coordinate.y] = new Tile { _coordinate = coordinate, _gameObject = generatedTiles, _distinctiveType = DistinctiveType.Cube };
        }
    }

}

