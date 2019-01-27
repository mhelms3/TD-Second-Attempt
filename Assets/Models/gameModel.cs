using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class gameModel : MonoBehaviour
    {
        public gameMap _Map;

        // Use this for initialization
        void Start()
        {
            _Map = GetComponent<gameMap>();
            //gameMap = new mapData(tilesX, tilesY);
        }


        // Update is called once per frame
        void Update()
        {

        }
       
    }
}
