using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    
    public class godScript : MonoBehaviour
    {
        public int tilesX, tilesY;
        public tileView tv;
        public mapData gameMap;
        // Use this for initialization
        void Start()
        {
            gameMap = new mapData(tilesX, tilesY);
            //tv = new tileView();
                        
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
