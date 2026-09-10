using System;
using System.Collections.Generic;
using System.Text;

namespace homework2.Tasks
{
    public class Task2
    {
        public static string Run(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            int count = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1 || input[i] != input[i + 1])
                {
                    sb.Append(input[i]);
                    sb.Append(count);
                    count = 1; 
                }
                else
                {
                    count++;
                }
            }

            return sb.ToString();
        }
    }
}
