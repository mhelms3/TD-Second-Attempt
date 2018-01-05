using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class tileData 
    {
        private terrainData tData;
        private tilePosition tPos;
        
        
        public tileData(terrainType t, tilePosition p)
        {
            tData = new terrainData(t);
            tPos = new tilePosition();
            tPos = p;
        }       

        public Vector3 getVector3()
        {
            return tPos.getVector3();
        }

        public void printTileData ()
        {
            tData.printTerrainData();
            tPos.printTilePosition();
        }
    }
}
