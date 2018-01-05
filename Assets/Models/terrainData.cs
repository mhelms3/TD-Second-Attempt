using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class terrainData 
    {
        private terrainType tileTerrain;
        private bool impassable;
        private float moveCost;

        public terrainData(tdGame.terrainType tt)
        {
            tileTerrain = tt;
            impassable = false;
            moveCost = 1;
        }

        public void printTerrainData()
        {
            Debug.Log("Type: " + tileTerrain);
        }
    }
}
