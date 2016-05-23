using System;

namespace BrazzersSolver.Core.Extensions
{
    public static class StringExtensions
    {
        public static string GetBetween(this string source, string begin, string end)
        {
            var start = source.IndexOf(begin, StringComparison.Ordinal) + begin.Length;
            var last = source.IndexOf(end, start, StringComparison.Ordinal) - start;

            return source.Substring(start, last);
        }
    }
}  