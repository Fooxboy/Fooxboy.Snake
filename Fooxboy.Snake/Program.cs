using System;
using System.Text;
using Fooxboy.Snake.Enums;
using Fooxboy.Snake.Models;

namespace Fooxboy.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IGame game = new Game();
            game.StartGame(new GameCreateParam()
            {
                CharHeadSnake = "*",
                CharTailSnake = "#",
                CustomSpeed = 0,
                Height = 50,
                SpeedSnake = SpeedSnakeEnum.Normal,
                Width = 50
            });

            Console.ReadLine();
        }
    }
}
