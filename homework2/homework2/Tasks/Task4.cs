using System;
using System.Collections.Generic;
using System.Text;

namespace homework2.Tasks
{
    public class Task4
    {
        public static List<string> Run(List<string> names)
        {
            if (names == null)
                return new List<string>();

            List<string> result = new List<string>();

            foreach (string name in names)
            {
                if (!result.Contains(name))
                {
                    result.Add(name);
                }
            }

            result.Sort(StringComparer.OrdinalIgnoreCase);

            return result;
        }
    }
}
