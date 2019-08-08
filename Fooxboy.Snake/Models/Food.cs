using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.Snake.Models
{
    public class Food: IFood
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string CharFood { get; } = "A";
    }
}
