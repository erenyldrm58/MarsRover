using MarsRover.Application.Library.Interfaces;

namespace MarsRover.Application.Library.Entities
{
    /// <summary>
    /// Coordinat Class
    /// </summary>
    public class Coordinat : ICoordinat
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinat(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}