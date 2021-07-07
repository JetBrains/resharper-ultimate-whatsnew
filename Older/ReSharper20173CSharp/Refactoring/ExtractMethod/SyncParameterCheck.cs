using System;
using System.Threading.Tasks;

namespace ReSharper20173CSharp.Refactoring.ExtractMethod
{
    class SyncParameterCheck
    {
        static async Task<int> GetMultiple(int secondsDelay)
        {
            if (secondsDelay < 0 || secondsDelay > 5)
                throw new ArgumentOutOfRangeException("secondsDelay cannot exceed 5.");

            // Select from here to end, Ctrl+R, M (Extract mehod).
            // Choose local function, place at the end of GetMultiple method.
            Console.WriteLine("Executing GetValueAsync...");
            await Task.Delay(secondsDelay * 1000);
            return secondsDelay * new Random().Next(2, 10);
        }
    }
}