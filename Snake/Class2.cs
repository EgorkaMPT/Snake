using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Pixell
    {
        public readonly struct Pixel
        {
            private const char PixelChar = '#';
            public Pixel(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; }
            public int Y { get; }
            public void Draw()
            {
                Console.SetCursorPosition(left: X, top: Y);
                Console.Write(PixelChar);
            }
            public void Clear()
            {
                Console.SetCursorPosition(left: X, top: Y);
                Console.Write(' ');
            }
        }
    }
}
