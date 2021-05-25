using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OnLineFM.YouTubeParser
{
    internal static class yt
    {
        internal static bool isYT(string link) {
            return new Regex(@"(https?:\/\/)?(www\.)?youtu(be\.com|\.be)\/.*").IsMatch(link);
        }
    }
}
