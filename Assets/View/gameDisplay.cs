using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace tdGame
{
    public class gameDisplay : MonoBehaviour
    {
        public Text picksRemaining;
        public Text hammerssRemaining;
        public Text stoneAmount;
        public Text roundNumber;

        private playerModel _Player;

        // Start is called before the first frame update
        void Start()
        {
            _Player = FindObjectOfType<playerModel>();
        }

        void updateTopDisplay()
        {
            picksRemaining.text = _Player.picks.ToString();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
