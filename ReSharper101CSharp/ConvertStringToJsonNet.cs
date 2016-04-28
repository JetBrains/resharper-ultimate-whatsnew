using System;
using Newtonsoft.Json.Linq;
// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToConstant.Local
// ReSharper disable ArrangeTypeModifiers
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable UnusedVariable

namespace ReSharper101CSharp
{
    class ConvertStringToJsonNet
    {
        // 20161RTM: CA: Convert JSON string to Newtonsoft JSON.NET object.

        private void StringToJsonNetDemo()
        {
            var json = @"{ ""type"" : ""feature"",
                                ""properties"": {
                                ""name"" : ""JSON Converter""}
                                }";
            Console.WriteLine(json);
        }









    }
}
