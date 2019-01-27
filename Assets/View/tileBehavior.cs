using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class tileBehavior : MonoBehaviour
    {
        Color32 baseColor = new Color32(255, 255, 255, 255);
        
        private void OnMouseDown()
        {
            gameMap _Map = FindObjectOfType<gameMap>();
            gameModel _Game = FindObjectOfType<gameModel>();
            gameDisplay _Display = FindObjectOfType<gameDisplay>();
            playerModel _Player = FindObjectOfType<playerModel>();
            float miningCost = 0;
            int newStone = 0;
            Debug.Log("1:" + _Game.miningTimeRemaining);

            if (_Game.miningTimeRemaining > 0)
            {
                Vector3 p = transform.position;
                tileData td = _Map.tiles[(int)p.x, (int)p.y, (int)p.z];
                miningCost = td.miningCost;
                if (miningCost <= _Game.miningTimeRemaining)
                {
                    newStone = (5 + (int)(miningCost / 5));
                    _Player.stone += newStone;
                    usePick(miningCost, _Game, _Display);
                    this.GetComponent<SpriteRenderer>().sprite = _Map.floorSprites[0];
                    this.GetComponent<SpriteRenderer>().color = baseColor;
                }
            }
        }

        void usePick(float i, gameModel _g, gameDisplay _d)
        {
            _g.miningTimeRemaining -= i;
            _d.BroadcastMessage("updateTopDisplay");
        }
    }
}
