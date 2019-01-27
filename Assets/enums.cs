using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public struct tilePosition
    {
        public int positionX { get; set; }
        public int positionY { get; set; }

        public Vector3 getVector3()
        {
            return new Vector3(positionX, 0, positionY);
        }
        public void printTilePosition()
        {
            Debug.Log(positionX + ":" + positionY);
        }
    }
    
}
