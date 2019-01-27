using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace tdGame
{ 
    public class gameMap : MonoBehaviour
    {    
        public rockData[] rocks;
        public Sprite[] rockSprites;
        public Sprite[] floorSprites;
        public tileData[,,] tiles;
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
            /*
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    pos.x = i;
                    pos.y = j;
                    randomRock = UnityEngine.Random.Range(0, 3);
                    tiles[i, j, 0] = new tileData(rocks[randomRock], false, 1, pos);
                    tileObject  = Instantiate(protoTile, new Vector3(i, j, 0), Quaternion.identity);
                    randomTile = UnityEngine.Random.Range(0, 3);
                    tileOffset = 0;
                    tileObject.GetComponent<SpriteRenderer>().sprite = rockSprites[tileOffset+randomTile];
                    tileObject.GetComponent<SpriteRenderer>().color = rocks[randomRock].getRockColor();
                }
                */
            LoadMap();
        }


        private void splitFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                int countLine = 0;
                int countRow = 0;
                int t = 0;
                int randomRock = 0;
                Vector3Int pos = new Vector3Int();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    countRow = 0;
                    foreach (string s in values)
                    {
                        pos.x = countLine;
                        pos.y = countRow;
                        t = Convert.ToInt32(s);
                        tileObject = Instantiate(protoTile, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
                        if (t == 6)
                        {
                            tiles[pos.x, pos.y, 0] = new tileData(rocks[3], false, 99, pos);
                            tileObject.GetComponent<SpriteRenderer>().sprite = rockSprites[0];
                            tileObject.GetComponent<SpriteRenderer>().color = rocks[3].getRockColor();
                        }
                        else if (t<3)
                        {
                            tiles[pos.x, pos.y, 0] = new tileData(rocks[t], false, 9, pos);
                            tileObject.GetComponent<SpriteRenderer>().sprite = rockSprites[0];
                            tileObject.GetComponent<SpriteRenderer>().color = rocks[t].getRockColor();
                        }
                        else
                        {
                            if(t==5)
                            {
                                home.x = pos.x;
                                home.y = pos.y;
                            }
                            tiles[pos.x, pos.y, 0] = new tileData(rocks[4], true, 1, pos);
                            tileObject.GetComponent<SpriteRenderer>().sprite = floorSprites[0];
                            tileObject.GetComponent<SpriteRenderer>().color = rocks[4].getRockColor();
                        }
                        countRow++;
                    }
                    countLine++;
                }
            }
        }


        public void LoadMap ()
        {
            splitFile("map2526.csv");
        }



        private bool initializeRocks()
        {
            string[] rockNames = { "Dirt", "Gypsum", "Granite", "Boundary", "None"};
            int[] hardness = { 5, 20, 70, 99999, 99999};
            Color32[] colors = {new Color32(197, 72, 28, 255), new Color32(212, 195, 183, 255), new Color32(99, 75, 92, 255), new Color32(0, 0, 0, 255), new Color32(255, 255, 255, 255) };
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
