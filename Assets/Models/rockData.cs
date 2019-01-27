﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tdGame
{
    public class rockData
    {
        public string rockType { get; set; }
        public int hardness { get; set; }
        public Color32 rockColor { get; set;}

        public rockData(string r, int h, Color32 c)
        {
            rockType = r;
            hardness = h;
            rockColor = c;
        }

        public Color32 getRockColor()
        {
            return rockColor;
        }

        public void printRockData()
        {
            Debug.Log("Type: " + rockType + "Hardness: "+hardness);
        }
    }
}