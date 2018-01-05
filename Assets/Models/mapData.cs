using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class mapData 
    {
        private tileData[,] tiles;

        public tileData[,] getAllTiles()
        {
            return tiles;
        }

        public mapData(int width, int height)
        {
            tiles = new tileData[width, height];
            tdGame.tilePosition pos = new tilePosition();
            tdGame.terrainType tt;
            for (int i=0;i<width;i++)
                for(int j=0;j<height;j++)
                {
                    tt = tdGame.terrainType.Field;
                    pos.positionX = i;
                    pos.positionY = j;
                    tiles[i, j] = new tileData(tt, pos);
                    tiles[i, j].printTileData();
                }
        }
    }

    
}
