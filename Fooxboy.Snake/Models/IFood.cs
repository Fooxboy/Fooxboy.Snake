using System;
using System.Collections.Generic;
using System.Text;

namespace Fooxboy.Snake.Models
{
    public interface IFood
    {
        int X { get; set; }
        int Y { get; set; }
        string CharFood { get; }
    }
}
