using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.Snake.Enums;

namespace Fooxboy.Snake.Models
{
    public interface ISnakeCreateParam
    {
        int PositionX { get; set; }
        int PositionY { get; set; }
        SpeedSnakeEnum Speed { get; set; }
        int CustomSpeed { get; set; }
        int LengthTail { get; set; }
        IGame CurrentGame { get; set; }
    }
}
