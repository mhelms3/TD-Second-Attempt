using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace tdGame
{
    public class gameDisplay : MonoBehaviour
    {
        public Text miningTimeRemaining;
        public Text buildTimeRemaining;
        public Text stoneAmount;
        public Text earthManaAmount;
        public Text[] gemsAmount;
        

        private playerModel _Player;
        private gameModel _Game;

        // Start is called before the first frame update
        void Start()
        {
            _Player = FindObjectOfType<playerModel>();
            _Game = FindObjectOfType<gameModel>();
        }

        void updateTopDisplay()
        {
            miningTimeRemaining.text = _Game.miningTimeRemaining.ToString();
            stoneAmount.text = _Player.stone.ToString();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
