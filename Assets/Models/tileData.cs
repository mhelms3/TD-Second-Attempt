using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class tileData 
    {
        public bool isPassable { get; set; }
        public int moveCost { get; set; }
        public float miningCost { get; set; }
        private float miningComplete { get; set; }
        public rockData rockType;
        public int cracks;
        private Vector3Int tPos;
        public GameObject tile;
        
        public tileData(rockData r,  bool s, int m, Vector3Int p, GameObject t)
        {
            isPassable = s;
            moveCost = m;
            rockType = r;
            miningCost = r.hardness;
            tPos = new Vector3Int(p.x, p.y, p.z);
            tile = t;
        }       

        public Vector3 getTilePosition()
        {
            Vector3 v = new Vector3(0,0,0);
            v.x = tPos.x;
            v.y = tPos.y;
            v.z = tPos.z;
            return v;
        }

        public void printTileData ()
        {
            rockType.printRockData();
            Debug.Log("Tile Position x:" + tPos.x.ToString() + " y:" + tPos.y.ToString() + " z:"+ tPos.z.ToString()); ;
        }
    }
}
