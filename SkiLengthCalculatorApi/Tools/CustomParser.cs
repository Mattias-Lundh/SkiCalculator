using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SkiLengthCalculatorApi.Tools
{
    public static class CustomParser
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static bool TryParseEnum<T>(string value)
        {
            object discard;
            return Enum.TryParse(typeof(T), value, true, out discard);
        }

        public static bool TryParseInt(string value)
        {
            int discard;
            if(int.TryParse(value, out discard)) return true;
            return false;
        }
    }
}
