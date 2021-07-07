#pragma warning disable 8618
// ReSharper disable UnusedMember.Global

using System;

namespace ReSharper20212CSharp
{
    public static class SwapViaDeconstruction
    {
        // -- Swap via deconstruction
        // Caret on T temp ..., alt+enter, swap via deconstruction
        public static void ReverseContents<T>(this T[] array, int start, int count)
        {
            int end = start + count + 1;
            for (int i = 0, j = end; i < j; i++, j--)
            {
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // -- Replace empty array creation
        // Caret on new string[0], Alt+Enter, Use Array.Empty
        public static string[] Defaults = new string[0];

        // Caret on new Type[0], Alt+Enter, Use Type.EmptyTypes
        public static Type[] DefaultTypes = new Type[0];
    }
}