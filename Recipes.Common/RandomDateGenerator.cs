using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Common
{
    public class RandomDateGenerator
    {
        public static Random random = new Random();

        public static DateTime GenerateRandomDateTime(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return startDate + newSpan;
        }
    }
}
