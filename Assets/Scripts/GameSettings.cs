﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public static class GameSettings
    {
        public const int OPERATOR = 0,
                         SNIPER = 1,
                         CLOSE_QUARTERS = 2;

        public static int MAP_WIDTH = 15,
                          MAP_HEIGHT = 15,
                          SCENE_HELPER = 1;

        public static List<int> players = new List<int>();

    }
}
