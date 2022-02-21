using MarsRover.Application.Library.Entities;
using MarsRover.Application.Library.Enums;
using MarsRover.Application.Library.Extensions;
using System;

namespace MarsRover.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         MARS ROVER");

            Console.WriteLine("\n - Please enter X,Y coordinates of plateu(e.g => 5 5) : ");

            var plateauParams = Console.ReadLine().ToUpper().ConvertToStringList();
            var plateauResult = PlateauExtension.CheckPlateauParams(plateauParams);

            if (!plateauResult)
            {
                var errorMSg = "Plateu parameters are not valid!";
                Console.WriteLine(errorMSg);
            }

            Console.WriteLine("\n - Please enter X,Y coordinates and direction of rover: (e.g => 1 2 N)");

            var roverParams = Console.ReadLine().ToUpper().ConvertToStringList();
            var roverResult = RoverExtension.CheckRoverParams(roverParams);

            if (!roverResult)
            {
                var errorMSg = "Rover parameters are not valid!";
                Console.WriteLine(errorMSg);
            }

            Console.WriteLine("\n - Please enter move commmands parameters: (e.g => LMLMLMLMM)");

            string commmandParams = Console.ReadLine().ToUpper();
            var commmandResult = RoverExtension.CheckCommandParameters(commmandParams);

            if (!commmandResult)
            {
                var errorMSg = "Command parameters are not valid!";
                Console.WriteLine(errorMSg);
            }

            Plateau plateau = new Plateau(new Coordinat(int.Parse(plateauParams[0]), int.Parse(plateauParams[1])));
            Rover rover = new Rover(plateau, new Coordinat(int.Parse(roverParams[0]), int.Parse(roverParams[1])), (Directions)Enum.Parse(typeof(Directions), roverParams[2]));
            rover.Start(commmandParams);


            Console.WriteLine("\n - LAST ROVER POSITION");
            Console.WriteLine(rover.ToString());

            Console.ReadLine();
        }
    }
}
