using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.Snake.Enums;
using Fooxboy.Snake.Models;

namespace Fooxboy.Snake.Snakes
{
    public interface ISnake
    {
        int X { get; }
        int Y { get; }
        SpeedSnakeEnum Speed { get; }
        int CustomSpeed { get; set; }
        IList<ITailSnake> Tail { get; }
        DirectionEnum Direction { get; }
        string CharHeadSnake { get; }
        string CharTailSnake { get; }
        void AddTail();
        void AddTail(int count);
        void SetCharHeadSnake(string charHeadSnake);
        void SetCharTailSnake(string charTailSnake);
        void ToRight();
        void ToLeft();
        void ToUp();
        void ToDown();
        void UpdatePosition();
    }
}
