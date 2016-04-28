using System.Collections.Generic;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Local

namespace ReSharper101CSharp
{
    public class CheckMethodInputParameters
    {
        private void TakeManyParametersAndCheckThemAll(string myString, // 20161RTM: CA "Check parameter for null or empty/whitespace string"
                                               int myNumber, // 20161RTM: CA "Check if parameter is out of range"
                                               Country myCountry, // 20161RTM: CA "Check if enum parameter is defined by enum type"
                                               List<string> moarStrings) // 20161RTM: CA "Check if parameter is an empty collection"
        {
            if (false)
            {
                TakeManyParametersAndCheckThemAll(" ", -10, (Country)3235, new List<string>());
            }
        }
    }
}