using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    
    public class tileView : MonoBehaviour
    {
        public GameObject tilePrototype;

        public void buildTiles(mapData m)
        {
            foreach (tileData t in m.getAllTiles())
            {
                GameObject tile = (GameObject)Instantiate(tilePrototype, t.getVector3(), Quaternion.identity);
            }
        }

        public tileView()
        {

        }

    }
}
