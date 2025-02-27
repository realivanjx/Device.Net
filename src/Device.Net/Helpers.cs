﻿using System.Globalization;

namespace Device.Net
{
    /// <summary> 
    /// Provides helpers for all platforms. 
    /// </summary> 
    public static class Helpers
    {
        public static bool ContainsIgnoreCase(this string paragraph, string word)
        {
            return ParsingCulture.CompareInfo.IndexOf(paragraph, word, CompareOptions.IgnoreCase) >= 0;
        }

        public static string GetHex(uint? id)
        {
            //TODO: Fix code rules here
            return id?.ToString("X").ToLower().PadLeft(4, '0');
        }

        public static CultureInfo ParsingCulture { get; private set; } = new CultureInfo("en-US");
    }
}