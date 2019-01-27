using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class playerModel : MonoBehaviour
    {
        public int picks;
        public int hammers;
        public int stone;
        gameDisplay _Display;
        // Start is called before the first frame update
        void Start()
        {
            _Display = FindObjectOfType<gameDisplay>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void usePick()
        {
            picks -= 1;
            Debug.Log("Picks:" + picks);
            _Display.BroadcastMessage("updateTopDisplay");

        }
    }
}
