#pragma warning disable 8618
// ReSharper disable UnusedMember.Global

using System;

namespace CSharp20212.CodeAnalysis
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
    }
}