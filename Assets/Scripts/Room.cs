﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class Room
    {
        public int x, y, width, height;

        public Room leftRoom, rightRoom, parent, sibling;

        public Room(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.leftRoom = this.rightRoom = this.parent = this.sibling = null;
        }
    }
}
