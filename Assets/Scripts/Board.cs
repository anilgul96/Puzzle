using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Board
{
    public class Board : MonoBehaviour
    {
        [SerializeField] int xAxis = 0;
        [SerializeField] int yAxis = 0;

        SpawnTiles spawnTiles;

        private void Awake()
        {
            spawnTiles = FindObjectOfType<SpawnTiles>();
        }

        private void Start()
        {
            TryGenerateBoard();
        }

        private void TryGenerateBoard()
        {
            for (int i = 0; i < xAxis; i++)
            {
                for (int j = 0; j < yAxis; yAxis++)
                {
                    spawnTiles.TrySpawnTilesOnBoard(i, j);
                }
            }
        }
    }

}

