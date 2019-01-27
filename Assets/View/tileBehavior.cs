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
            playerModel _Player = FindObjectOfType<playerModel>();
            
            if (_Player.picks > 0)
            {
                _Player.SendMessage("usePick");
                FindObjectOfType<gameDisplay>().SendMessage("updateTopDisplay");
                this.GetComponent<SpriteRenderer>().sprite = _Map.floorSprites[0];
                this.GetComponent<SpriteRenderer>().color = baseColor;
                //gameObject.SendMessage("crack");
            }
                
            //int randFloor = Random.Range(0, 5);
            //Debug.Log("L:"+_Map.floorSprites.Length);

            
        }
    }
}
