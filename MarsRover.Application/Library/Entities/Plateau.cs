using MarsRover.Application.Library.Interfaces;

namespace MarsRover.Application.Library.Entities
{
    /// <summary>
    /// Plateau Class
    /// </summary>
    public class Plateau : IPlateau
    {
        public Coordinat PlateauDimension { get; private set; }

        public Plateau(Coordinat coordinat)
        {
            PlateauDimension = coordinat;
        }
    }
}
