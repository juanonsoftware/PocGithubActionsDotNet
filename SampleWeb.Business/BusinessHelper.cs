using System;
using System.Collections.Generic;

namespace SampleWeb.Business
{
    /// <summary>
    /// Helper methods for business layer
    /// </summary>
    public static class BusinessHelper
    {
        /// <summary>
        /// Get a random list of strings
        /// </summary>
        /// <returns></returns>
        public static IList<string> BuildRandomStrings()
        {
            var ranNumber = new Random().Next(1, 101);

            var result = new List<string>();
            var dictionary = new Dictionary<int, string>()
            {
                {0, "Zero" },
                {1, "One" }
            };

            for (var count = 0; count < ranNumber; count++)
            {
                result.Add(dictionary[count % 2]);
            }

            return result;
        }
    }
}
