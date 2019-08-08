using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.Snake.Enums;

namespace Fooxboy.Snake.Models
{
    public class SnakeCreateParam: ISnakeCreateParam
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public SpeedSnakeEnum Speed { get; set; }
        public int CustomSpeed { get; set; } = 0;
        public int LengthTail { get; set; }
        public IGame CurrentGame { get; set; }
    }
}
