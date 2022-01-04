using System;
using System.Collections.Generic;

namespace WinFormsAppNetFramework.ExtensionMethods
{
    public static class IEnumerable
    {
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence)
                action(item);
        }
    }
}
