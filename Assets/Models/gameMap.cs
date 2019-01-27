using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{ 
    public class gameMap : MonoBehaviour
    {    
        public rockData[] rocks;
        public Sprite[] rockSprites;
        public Sprite[] floorSprites;
        private tileData[,,] tiles;
        private GameObject tileObject;
        public GameObject protoTile;
        public int width;
        public int height;
        public Vector2Int home;

        public tileData[,,] getAllTiles()
        {
            return tiles;
        }

        void Awake()
        {
            initializeRocks();
            tiles = new tileData[width, height, 3];
            Vector3Int pos = new Vector3Int();
            home.x = width / 2;
            home.y = height / 2;
            int randomRock;
            int randomTile;
            int tileOffset;
            
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    pos.x = i;
                    pos.y = j;
                    randomRock = Random.Range(0, 3);
                    tiles[i, j, 0] = new tileData(rocks[randomRock], false, 1, pos);
                    tileObject  = Instantiate(protoTile, new Vector3(i, j, 0), Quaternion.identity);
                    randomTile = Random.Range(0, 4);
                    tileOffset = 0;
                    tileObject.GetComponent<SpriteRenderer>().sprite = rockSprites[tileOffset+randomTile];
                    tileObject.GetComponent<SpriteRenderer>().color = rocks[randomRock].getRockColor();
                }
        }

        private bool initializeRocks()
        {
            string[] rockNames = { "Dirt", "Gypsum", "Granite" };
            int[] hardness = { 5, 20, 70 };
            Color32[] colors = {new Color32(197, 72, 28, 255), new Color32(212, 195, 183, 255), new Color32(99, 75, 92, 255) };
            int counter = 0;
            rocks = new rockData[rockNames.Length];
            foreach (string s in rockNames)
            {
                rocks[counter] = new rockData(s, hardness[counter], colors[counter]);
                counter++;
            }
            return true;
        }
        public rockData getRocks(int i)
        {
            return rocks[i];
        }

        public void outputMapData()
        {
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tiles[i, j, 0].printTileData();
                }
            }
        }
    }

    
}
