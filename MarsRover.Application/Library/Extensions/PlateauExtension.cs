using System;
using System.Collections.Generic;

namespace MarsRover.Application.Library.Extensions
{
    public static class PlateauExtension
    {
        /// <summary>
        /// Check Plateau Parameters are Valid
        /// </summary>
        /// <param name="plateauParams"></param>
        /// <returns></returns>
        public static bool CheckPlateauParams(this List<string> plateauParams)
        {
            try
            {
                if (plateauParams.Count != 2)
                {
                    return false;
                }

                _ = int.TryParse(plateauParams[0], out int x);
                _ = int.TryParse(plateauParams[1], out int y);

                if (x == 0 || y == 0)
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
    }
}
