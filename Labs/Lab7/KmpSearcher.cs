using System.Collections.Generic;

namespace Lab7
{
    public static class KmpSearcher
    {
        public static IEnumerable<int> Search(string pattern, string text)
        {
            var res = new List<int>();
            
            var lps = new int[pattern.Length];
            var patIdx = 0;
            
            ComputeLpsArray(pattern, pattern.Length, lps);

            var textIdx = 0;
            while (textIdx < text.Length)
            {
                if (pattern[patIdx] == text[textIdx])
                {
                    patIdx++;
                    textIdx++;
                }

                if (patIdx == pattern.Length)
                {
                   res.Add(textIdx - patIdx);
                   patIdx = lps[patIdx - 1];
                }

                else if (textIdx < text.Length && pattern[patIdx] != text[textIdx])
                {;
                    if (patIdx != 0)
                        patIdx = lps[patIdx - 1];
                    else
                        textIdx++;
                }
            }

            return res;
        }

        private static void ComputeLpsArray(string pat, int patLength, IList<int> lps)
        {
            var len = 0;
            var idx = 1;
            lps[0] = 0; 
            
            while (idx < patLength)
            {
                if (pat[idx] == pat[len])
                {
                    len++;
                    lps[idx] = len;
                    idx++;
                }
                else 
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else 
                    {
                        lps[idx] = len;
                        idx++;
                    }
                }
            }
        }
    }
}