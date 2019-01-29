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
            if (gameObject.layer == 8)
            { }
            else
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
                    miningCost = _Map.tiles[(int)p.x, (int)p.y, (int)p.z].miningCost;
                    if (miningCost <= _Game.miningTimeRemaining)
                    {
                        newStone = (5 + (int)(miningCost / 5));
                        _Player.stone += newStone;
                        usePick(miningCost, _Game, _Display);
                        //Debug.Log(_Map.tiles[(int)p.x, (int)p.y, (int)p.z].rockType.rockName);
                        _Map.tiles[(int)p.x, (int)p.y, (int)p.z].rockType = _Map.rocks[4];
                        //Debug.Log(_Map.tiles[(int)p.x, (int)p.y, (int)p.z].rockType.rockName);
                        this.GetComponent<SpriteRenderer>().sprite = _Map.floorSprites[0];
                        this.GetComponent<SpriteRenderer>().color = baseColor;
                        _Map.spreadActivation((int)p.x, (int)p.y);
                    }
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
