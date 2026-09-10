using System;
using System.Collections.Generic;
using System.Text;

namespace homework2.Tasks
{
    public class Task3
    {
        public static bool Run(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                while (left < right && char.IsWhiteSpace(s[left]))
                    left++;

                while (left < right && char.IsWhiteSpace(s[right]))
                    right--;

                if (left >= right)
                    break;

                string leftChar = s[left].ToString();
                string rightChar = s[right].ToString();

                if (!string.Equals(leftChar, rightChar, StringComparison.OrdinalIgnoreCase))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
