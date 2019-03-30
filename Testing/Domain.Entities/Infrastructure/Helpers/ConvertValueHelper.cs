using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Domain.Entities.Infrastructure.Helpers
{
    public static class ConvertValueHelper
    {
        public static string ConvertListToStringForDB(List<string> item)
        {
            return string.Join(",", item);
        }

        public static string ConvertListToStringForView(List<string> item)
        {
            return string.Join("\n", item);
        }

        public static List<string> ConvertStringToList(string item)
        {
            return item.Split(',').ToList();
        }

        public static List<string> ConvertStringViewToList(string item)
        {
            return item.Split('\n').ToList();
        }
    }
}
