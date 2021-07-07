using System.Xml.Linq;
// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToConstant.Local
// ReSharper disable ArrangeTypeModifiers
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable UnusedVariable

namespace ReSharper101CSharp
{
    class ConvertStringToLinqToXml
    {
        // 20161RTM: CA: Convert XML string to LINQ to XML object.

        private void StringToLinqXmlDemo()
        {
            var myXml = XDocument.Parse(@"<message title=""Meeting"">
                                <from>Jack Lee</from>
                                <to>John Doe</to>                        
                                <body>Meeting in rooom 309 today is postponed to 16:00</body>
                                </message>");
        }






    }
}
