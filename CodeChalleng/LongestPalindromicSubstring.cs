using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChalleng
{
    class LongestPalindromicSubstring
    {
        public String longestPalindrome(String s)
        {
            int start = 0;
            int end = 0;
            if (s == null || s.Length < 1)
            {
                return "";
            }

            for (int i=0; i< s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if(len > end - start)
                {
                    start = i - ((len - 1) / 2);
                    end = i + (len / 2);
                }
            }

            return s.Substring(start, end +1 );
        }

        private int expandAroundCenter(String s, int left, int right)
        {
            while(left >=0 && right <s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }

        public string LongestPalindrome_Manacher(string s)
        {
            if (s.Length == 0)
            {
                return "";
            }

            string T = preProcess(s);
            int n = T.Length;
            int[] P = new int[n];
            int C = 0, R = 0;

            for (int i = 1; i < n - 1; i++)
            {
                int i_mirror = 2 * C - i; // equals to i' = C - (i-C)

                P[i] = (R > i) ? Math.Min(R - i, P[i_mirror]) : 0;

                // Attempt to expand palindrome centered at i
                while (T[i + 1 + P[i]] == T[i - 1 - P[i]])
                    P[i]++;

                // If palindrome centered at i expand past R,
                // adjust center based on expanded palindrome.
                if (i + P[i] > R)
                {
                    C = i;
                    R = i + P[i];
                }
            }

            // Find the maximum element in P.
            int maxLen = 0;
            int centerIndex = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (P[i] > maxLen)
                {
                    maxLen = P[i];
                    centerIndex = i;
                }
            }

            return s.Substring((centerIndex - 1 - maxLen) / 2, maxLen);
        }

        private string preProcess(string s)
        {
            StringBuilder sb = new StringBuilder(s.Length * 2 + 3);
            sb.Append('^');

            foreach (char c in s)
            {
                sb.Append('#');
                sb.Append(c);
            }

            sb.Append("#$");

            return sb.ToString();
        }
    }
}
