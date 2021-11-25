namespace CS10.InterpolatedStringHandler;

using System.Runtime.CompilerServices;
using System.Text;



internal class InterpolatedStringHandlers 
{
    void PassStringInterpolation(string[] args) 
    {
        Logger.Log("length = {0}", args.Length); // QF "Pass string interpolation"

        Logger.IsEnabled = true;

        Logger.Log("length = {0}", args.Length);
    }
}

public static class Logger
{
    public static bool IsEnabled;

    [StringFormatMethod("format")]
    public static void Log(string format, params object[] args)
    {
        if (IsEnabled)
        {
            WriteToFile(string.Format(format, args));
        }
    }

    public static void Log(ref CustomInterpolatedStringHandler handler)
    {
        var message = handler.ToString();
        if (message != null)
        {
            WriteToFile(message);
        }
    }

    private static void WriteToFile(string message)
    {
        Console.WriteLine(message);
    }

    [InterpolatedStringHandler]
    public readonly struct CustomInterpolatedStringHandler
    {
        private readonly StringBuilder? _builder;

        public CustomInterpolatedStringHandler(int literalLength, int formattedCount, out bool shouldAppend)
        {
            if (IsEnabled) // logging is enabled
            {
                this._builder = new StringBuilder(capacity: literalLength + formattedCount * 11);
                shouldAppend = true;
            }
            else
            {
                this._builder = null;
                shouldAppend = false;
            }
        }

        public void AppendLiteral(string value) => this._builder?.Append(value);
        public void AppendFormatted<T>(T value) => this._builder?.Append(value);
        public void AppendFormatted(string? value) => this._builder?.Append(value);

        public override string? ToString() => this._builder?.ToString();
    }
}