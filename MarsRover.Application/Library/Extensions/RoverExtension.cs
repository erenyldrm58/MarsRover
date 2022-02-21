using MarsRover.Application.Library.Enums;
using System;
using System.Collections.Generic;

namespace MarsRover.Application.Library.Extensions
{
    public static class RoverExtension
    {
        /// <summary>
        /// Check Rover Parameters are Valid
        /// </summary>
        /// <param name="roverParams"></param>
        /// <returns></returns>
        public static bool CheckRoverParams(this List<string> roverParams)
        {
            try
            {
                if (roverParams.Count != 3)
                {
                    return false;
                }

                _ = int.TryParse(roverParams[0], out int x);
                _ = int.TryParse(roverParams[1], out int y);
                var direction = roverParams[2];

                if (x < 0 || y < 0 || !Enum.IsDefined(typeof(Directions), direction))
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Check Move Command Parameters are Valid
        /// </summary>
        /// <param name="commandParams"></param>
        /// <returns></returns>
        public static bool CheckCommandParameters(this string commandParams)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(commandParams))
                {
                    return false;
                }

                commandParams = commandParams.Trim();

                var commandsArray = commandParams.ToCharArray();

                foreach (var command in commandsArray)
                {
                    _ = Enum.TryParse(command.ToString(), out MoveCommands moveCommand);

                    if (command == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}