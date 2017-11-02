using System;

namespace ReSharper20173CSharp.Deconstructors
{
    public static class DateTimeExtensions
    {
        public static void Deconstruct(
            this DateTime dateTime, out int year, out int month, out int day)
        {
            year = dateTime.Year;
            month = dateTime.Month;
            day = dateTime.Day;
        }
    }

    public class FindUsagesDeconstructor
    {
        /// In <see cref="DateTimeExtensions.Deconstruct"/>, use Navigate To (Alt+`) to find usages of the extension method.

        public void Usage1()
        {
            (int year, int month, int day) = DateTime.UtcNow;
        }

        public void Usage2()
        {
            (int year, int month, int day) = DateTime.UtcNow;
        }
    }
}