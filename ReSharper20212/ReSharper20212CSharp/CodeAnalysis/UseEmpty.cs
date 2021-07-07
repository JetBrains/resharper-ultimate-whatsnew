#pragma warning disable 8618
// ReSharper disable UnusedMember.Global

using System;

namespace ReSharper20212CSharp
{
    public class UseEmpty
    {
        // -- Replace empty array creation
        // Caret on new string[0], Alt+Enter, Use Array.Empty
        public static string[] Defaults = new string[0];

        // Caret on new Type[0], Alt+Enter, Use Type.EmptyTypes
        public static Type[] DefaultTypes = new Type[0];

        public void RaiseEvent()
        {
            // Caret on new EventArgs, Alt+Enter, Use EventArgs.Empty
            OnEventRaised(this, new EventArgs());
        }

        // Collapse this one for screenshots
        public static void OnEventRaised(object sender, EventArgs e)
        {
            Console.WriteLine("Event was raised.");
        }
    }
}
