using MarsRover.Application.Library.Enums;

namespace MarsRover.Application.Library.Interfaces
{
    /// <summary>
    /// Rover Interface
    /// </summary>
    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        ICoordinat RoverCoordinat { get; set; }
        Directions RoverDirection { get; set; }
        void Start(string commands);
        string ToString();
    }
}