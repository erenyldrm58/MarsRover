using MarsRover.Application.Library.Enums;
using MarsRover.Application.Library.Interfaces;
using System;

namespace MarsRover.Application.Library.Entities
{
    /// <summary>
    /// Rover Class
    /// </summary>
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public ICoordinat RoverCoordinat { get; set; }
        public Directions RoverDirection { get; set; }

        public Rover(IPlateau roverPlateau, ICoordinat roverCoordinat, Directions roverDirection)
        {
            RoverPlateau = roverPlateau;
            RoverCoordinat = roverCoordinat;
            RoverDirection = roverDirection;
        }

        /// <summary>
        /// Start
        /// </summary>
        /// <param name="commands"></param>
        public void Start(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid parameters of movement: {0}", command));
                }
            }
        }

        /// <summary>
        /// Turn Left
        /// </summary>
        private void TurnLeft()
        {
            RoverDirection = (RoverDirection - 1) < Directions.N ? Directions.W : RoverDirection - 1;
        }

        /// <summary>
        /// Turn Right
        /// </summary>
        private void TurnRight()
        {
            RoverDirection = (RoverDirection + 1) > Directions.W ? Directions.N : RoverDirection + 1;
        }

        /// <summary>
        /// Move Rover
        /// </summary>
        private void Move()
        {
            if (RoverDirection == Directions.N)
            {
                RoverCoordinat.Y++;
            }
            else if (RoverDirection == Directions.E)
            {
                RoverCoordinat.X++;
            }
            else if (RoverDirection == Directions.S)
            {
                RoverCoordinat.Y--;
            }
            else if (RoverDirection == Directions.W)
            {
                RoverCoordinat.X--;
            }
        }

        /// <summary>
        /// ToString Override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string roverPosition = string.Format("{0} {1} {2}", RoverCoordinat.X, RoverCoordinat.Y, RoverDirection);
            if (!IsRoverInsidePletau())
                roverPosition =
                    string.Format("Rover outside the plateau! Plateau dimension:, Rover position: {0}, {1}", RoverPlateau.PlateauDimension.ToString(), roverPosition);

            return roverPosition;
        }

        /// <summary>
        /// Rover last position check
        /// </summary>
        /// <returns></returns>
        public bool IsRoverInsidePletau()
        {
            bool isInside = true;
            if (RoverCoordinat.X > RoverPlateau.PlateauDimension.X || RoverCoordinat.Y > RoverPlateau.PlateauDimension.Y)
                isInside = false;
            return isInside;
        }
    }
}
