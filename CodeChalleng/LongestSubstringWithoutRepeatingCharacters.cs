using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChalleng
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        public LongestSubstringWithoutRepeatingCharacters()
        {
        }

        public int lengthOfLongestSubstring(string s)
        {
            int n = s.Length;

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (checkRepetition(s, i, j))
                    {
                        res = Math.Max(res, j - i + 1);
                    }
                }
            }

            return res;
        }

        private bool checkRepetition(string s, int start, int end)
        {
            int[] chars = new int[128];

            for (int i = start; i <= end; i++)
            {
                char c = s[i];
                chars[c]++;
                if (chars[c] > 1)
                {
                    return false;
                }
            }
            return true;
        }

        public int lengthOfLongestSubstring_SlidingWindow(String s)
        {
            int[] chars = new int[128];

            int left = 0;
            int right = 0;

            int res = 0;
            while (right < s.Length)
            {
                char r = s[right];
                chars[r]++;

                while (chars[r] > 1)
                {
                    char l = s[left];
                    chars[l]--;
                    left++;
                }

                res = Math.Max(res, right - left + 1);

                right++;
            }
            return res;
        }
    }
}
