using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Room : MapSide
    {
        int roomNumber = 0;
        Dictionary<Direction, MapSide> sides;

        public Room(int roomNo)
        {
            this.roomNumber = roomNo;
            sides = new Dictionary<Direction, MapSide>(4);
        }
        public override void Enter()
        {
            Console.WriteLine("Room");
        }
        public MapSide GetSide(Direction direction)
        {
            return sides[direction];
        }
        public void SetSide(Direction direction, MapSide mapSide)
        {
            this.sides.Add(direction, mapSide);
        }
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
    }
}
