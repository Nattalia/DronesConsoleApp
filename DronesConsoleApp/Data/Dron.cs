using DronesConsoleApp.Common;
using DronesConsoleApp.CustomException;
using System;
using System.Collections.Generic;
using System.Text;

namespace DronesConsoleApp.Data
{
    /// <summary>
    /// Class that represents dron properties and actions.
    /// </summary>
    public class Dron
    {
        public FlyingArea FlyingArea { get; set; }

        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public Direction Direction { get; set; }

        /// <summary>
        /// Constructor to initialize Dron properties.
        /// </summary>
        /// <param name="flyingArea">Sets flying area rectangle.</param>
        /// <param name="xPosition">Dron start position at X axis.</param>
        /// <param name="yPosition">Dron start prosition at Y axis.</param>
        /// <param name="direction">Dron start orientation.</param>
        public Dron(FlyingArea flyingArea, int xPosition, int yPosition, Direction direction)
        {
            FlyingArea = flyingArea;

            XPosition = xPosition;
            YPosition = yPosition;
            Direction = direction;
        }

        /// <summary>
        /// Method to make dron turn left. 
        /// </summary>
        public void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.W;
                    break;
                case Direction.E:
                    Direction = Direction.N;
                    break;
                case Direction.S:
                    Direction = Direction.E;
                    break;
                case Direction.W:
                    Direction = Direction.S;
                    break;
            }
        }

        /// <summary>
        /// Method to make dron turn right.
        /// </summary>
        public void TurnRight()
        {
            switch (Direction)
            {
                case Direction.N:
                    Direction = Direction.E;
                    break;
                case Direction.E:
                    Direction = Direction.S;
                    break;
                case Direction.S:
                    Direction = Direction.W;
                    break;
                case Direction.W:
                    Direction = Direction.N;
                    break;
            }
        }

        /// <summary>
        /// Method to make dron move one point through flying area rectangle.
        /// </summary>
        public void MoveFordward()
        {
            // Set dron x and y axis position.
            int XPositionAux = XPosition;
            int YPositionAux = YPosition;

            switch (Direction)
            {
                case Direction.N:
                    YPositionAux++;
                    break;
                case Direction.E:
                    XPositionAux++;
                    break;
                case Direction.S:
                    YPositionAux--;
                    break;
                case Direction.W:
                    XPositionAux--;
                    break;
            }

            // Check if we are out of flying area. If so, throw exception.
            if (Utils.Between(XPositionAux, 0, FlyingArea.Width) && Utils.Between(YPositionAux, 0, FlyingArea.Height))
            {
                XPosition = XPositionAux;
                YPosition = YPositionAux;
            }
            else
            {
                throw new OutOfFlyingAreaException(Messages.outOfFlyingAreaMessage);
            }
                
        }

        /// <summary>
        /// Method that overrides ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", XPosition, YPosition, Direction.ToString());
        }
    }
}
