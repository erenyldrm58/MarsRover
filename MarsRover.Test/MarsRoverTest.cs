using MarsRover.Application.Library.Entities;
using MarsRover.Application.Library.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
    /// <summary>
    /// Test Class for Rover
    /// </summary>
    [TestClass]
    public class MarsRoverTest
    {
        /// <summary>
        /// Test method Rover check
        /// </summary>
        [TestMethod]
        public void FirstRoverCheckOutput()
        {
            Plateau plateauOne = new Plateau(new Coordinat(5, 5));
            Rover firstRover = new Rover(plateauOne, new Coordinat(1, 2), Directions.N);
            firstRover.Start("LMLMLMLMM");
            Assert.AreEqual(firstRover.ToString(), "1 3 N");
        }
    }
}
