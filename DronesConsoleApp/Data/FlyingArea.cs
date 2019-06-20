using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Data
{
    /// <summary>
    /// Class that represents flying area rectangle
    /// </summary>
    public class FlyingArea
    {
        public int Width { get; }
        public int Height { get; }

        /// <summary>
        /// Constructor to initialize flying area
        /// </summary>
        /// <param name="width">Width of flying area rectangle</param>
        /// <param name="height">Heigh</param>
        public FlyingArea(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
