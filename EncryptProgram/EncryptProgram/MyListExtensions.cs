using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptProgram
{
    public static class MyListExtensions
    {
        public static IEnumerable<T> GetRange<T>(this List<T> list, int lastIndex, int startIndex = 0)
        {
            for (int i = startIndex; i < list.Count; i += lastIndex)
            {
                yield return list[i];
            }
        }

        public static IEnumerable<T> GetRangeLinq<T>(this List<T> list, int lastIndex, int startIndex = 0)
        {
            return from i in Enumerable.Range(startIndex, ((list.Count - 1) / lastIndex) + 1)
                   select list[lastIndex * i];
        }

        public static string GetEncryptedChar(this List<string> list, char charc, int key)
        {
            var str = !Char.IsNumber(charc) && Char.IsUpper(charc) ? charc.ToString().ToLower() : charc.ToString();
            if (list.Contains(str))
            {
                var encryptedStr = list.ElementAtOrDefault(list.IndexOf(str) + key);
                if (encryptedStr == null)
                {
                    encryptedStr = list.ElementAtOrDefault((list.IndexOf(str) + key) - list.Count);
                }
                if (!Char.IsNumber(charc) && Char.IsUpper(charc))
                {
                    return encryptedStr.ToUpper();
                }
                return encryptedStr;
            }
            return string.Empty;
        }
    }
}
