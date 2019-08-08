using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.Snake.Enums;

namespace Fooxboy.Snake.Models
{
    public interface IGameCreateParam
    {
        int Width { get; set; }
        int Height { get; set; }
        string CharHeadSnake { get; set; }
        string CharTailSnake { get; set; }
        SpeedSnakeEnum SpeedSnake { get; set; }
        int CustomSpeed { get; set; }
    }
}
