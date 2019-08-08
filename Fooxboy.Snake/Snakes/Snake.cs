using System;
using System.Collections.Generic;
using System.Text;
using Fooxboy.Snake.Enums;
using Fooxboy.Snake.Models;

namespace Fooxboy.Snake.Snakes
{
    public class Snake:ISnake
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public SpeedSnakeEnum Speed { get; private set; }
        public int CustomSpeed { get; set; }
        public IList<ITailSnake> Tail { get; private set; }
        public DirectionEnum Direction { get; private set; }
        public string CharHeadSnake { get; private set; }
        public string CharTailSnake { get; private set; }

        private  IGame game { get;}

        public Snake(ISnakeCreateParam param)
        {
            if(X < 0 || Y < 0) throw  new ArgumentException("Координаты змейки не могут быть меньше нуля.");
            if(param == null) throw new ArgumentException("param не может быть равен null");
            game = param.CurrentGame;
            X = param.PositionX;
            Y = param.PositionY;
            Speed = param.Speed;
            CustomSpeed = param.CustomSpeed;
            Direction = DirectionEnum.Right;
            Tail = new List<ITailSnake>();
            for (int i = 0; i < param.LengthTail; i++)
            {
                Tail.Add(new TailSnake() {X= X- i, Y = Y});
            }
        }
        public void AddTail() => Tail.Add(new TailSnake() { X = Tail.Count, Y = 0});

        public void AddTail(int count)
        {
            for(int i = 0; i < count; i++) AddTail();
        }

        public void SetCharHeadSnake(string charHeadSnake)=> CharHeadSnake = charHeadSnake;

        public void SetCharTailSnake(string charTailSnake) => CharTailSnake = charTailSnake;

        public void ToRight() => this.Direction = DirectionEnum.Right;

        public void ToLeft() => this.Direction = DirectionEnum.Left;

        public void ToUp() => this.Direction = DirectionEnum.Up;

        public void ToDown() => this.Direction = DirectionEnum.Down;

        public void UpdatePosition()
        {
            this.Tail[0].X = X;
            this.Tail[0].Y = Y;
            game.ClearTail(this.Tail[this.Tail.Count - 1].X, this.Tail[this.Tail.Count - 1].Y);
            for (int i = 1; i< this.Tail.Count; i++) this.Tail[i] = this.Tail[i - 1];
            if (this.Direction == DirectionEnum.Right) X = X + 1;
            else if (this.Direction == DirectionEnum.Left) X = X - 1;
            else if (this.Direction == DirectionEnum.Up) Y = Y + 1;
            else if (this.Direction == DirectionEnum.Down) Y = Y - 1;
            game.DrawHead(this.X, this.Y);
            game.DrawTail(this.Tail[0].X, this.Tail[0].Y);
        }

    }
}
