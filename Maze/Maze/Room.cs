﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Room : MapSide
    {
        private int roomNumber;
        private Dictionary<Direction, MapSide> sides;

        public Room(int roomNo)
        {
            this.roomNumber = roomNo;
            sides = new Dictionary<Direction, MapSide>(4);
        }
        public override void Enter()
        {
            Console.WriteLine("Room" + roomNumber);
        }

        public MapSide GetSide(Direction direction)
        {
            return sides[direction];
        }
        public void SetSide(Direction direction, MapSide mapSite)
        {
            this.sides.Add(direction, mapSite);
        }
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
    }
}
