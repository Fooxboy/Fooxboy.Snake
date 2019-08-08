using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.Snake.Enums;

namespace Fooxboy.Snake.Models
{
    public class GameCreateParam: IGameCreateParam
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string CharHeadSnake { get; set; }
        public string CharTailSnake { get; set; }
        public SpeedSnakeEnum SpeedSnake { get; set; }
        public int CustomSpeed { get; set; } = 0;
    }
}
