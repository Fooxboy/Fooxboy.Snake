using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Fooxboy.Snake.Enums;
using Fooxboy.Snake.Models;
using Fooxboy.Snake.Snakes;

namespace Fooxboy.Snake
{
    public class Game: IGame
    {
        public ISnake Snake { get; set; }
        public IFood Food { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public void DrawHead(int x, int y)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(Snake.CharHeadSnake);
        }

        public void DrawTail(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Snake.CharTailSnake);
        }

        public void ClearTail(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        public void StartGame(IGameCreateParam param)
        {
            if (param == null) throw new ArgumentException("param не может быть равен null");
            this.Height = param.Height;
            this.Width = param.Width;
            Snake = new Snakes.Snake(new SnakeCreateParam()
            {
                CustomSpeed = param.CustomSpeed,
                LengthTail = 3,
                PositionX = 10,
                PositionY = 10,
                Speed = param.SpeedSnake,
                CurrentGame = this
            });

            Snake.SetCharHeadSnake(param.CharHeadSnake);
            Snake.SetCharTailSnake(param.CharTailSnake);
            CreateFood();

            var runGameTask = Task.Run(Update);
            var runKeyListenerTask = Task.Run(KeyListener);
        }

        private void Update()
        {
            while (true)
            {
                if (Snake.X == Food.X && Snake.Y == Food.Y) TakeFood();
                Snake.UpdatePosition();
                if(this.Snake.Speed != SpeedSnakeEnum.Custom) Thread.Sleep((int)this.Snake.Speed * 200);
                else Thread.Sleep(this.Snake.CustomSpeed * 200);
            }
        }

        private void KeyListener()
        {
            while (true)
            {
                var key = Console.ReadKey(false).Key;
                if(key == ConsoleKey.UpArrow) this.Snake.ToUp();
                else if(key == ConsoleKey.DownArrow) this.Snake.ToDown();
                else if(key == ConsoleKey.RightArrow) this.Snake.ToRight();
                else if(key == ConsoleKey.LeftArrow) this.Snake.ToLeft();
            }
        }

        public void CreateFood()
        {
            var random = new Random();
            IFood food = new Food()
            {
                X = random.Next(0, Width),
                Y = random.Next(0, Width),
            };

            Console.SetCursorPosition(food.X, food.Y);
            Console.Write(food.CharFood);
            this.Food = food;
        }

        public void TakeFood()
        {
            Console.SetCursorPosition(Food.X, Food.Y);
            Console.Write(" ");

            CreateFood();
        }
    }
}
