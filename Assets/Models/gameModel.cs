using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class gameModel : MonoBehaviour
    {
        public gameMap _Map;
        public playerModel _Player;
        public gameDisplay _Display;

        public float miningTimeRemaining;

        // Use this for initialization
        void Start()
        {
            _Map = FindObjectOfType<gameMap>();
            _Player = FindObjectOfType<playerModel>();
            _Display = FindObjectOfType<gameDisplay>();
            miningTimeRemaining = _Player.baseMiningTime;
        }

        // Update is called once per frame
        void Update()
        {

        }
       
    }
}
