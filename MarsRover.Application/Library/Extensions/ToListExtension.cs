using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Application.Library.Extensions
{
    public static class ToListExtension
    {
        /// <summary>
        /// Convert to string list from text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static List<string> ConvertToStringList(this string text)
        {
            return text.Trim().Split(' ').ToList();
        }
    }
}