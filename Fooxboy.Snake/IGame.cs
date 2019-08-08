using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.Snake.Models;
using Fooxboy.Snake.Snakes;

namespace Fooxboy.Snake
{
    public interface IGame
    {
        ISnake Snake { get; set; }
        IFood Food { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        void DrawHead(int x, int y);
        void DrawTail(int x, int y);
        void ClearTail(int x, int y);
        void StartGame(IGameCreateParam param);
        void CreateFood();
        void TakeFood();
    }
}
