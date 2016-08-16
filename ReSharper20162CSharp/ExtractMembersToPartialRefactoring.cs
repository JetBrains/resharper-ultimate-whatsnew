namespace ReSharper20162CSharp
{
    // 20162RTM: Extract Members to Partial refactoring (moves members between class parts; creates new parts if necessary): 3 scenarios

    // Refactor This on class name to decide which members to move to another part
    partial class PartialClass
    {
        // Refactor This on member name to move this member to another part
        public int IntegerProperty { get; set; }

        // Refactor This on region name to extract all members in the region to a separate part

        #region MyRegion

        public string StringProperty1 { get; set; }
        public string StringProperty2 { get; set; }

        #endregion

        public PartialClass(string stringProperty1, string stringProperty2)
        {
            StringProperty1 = stringProperty1;
            StringProperty2 = stringProperty2;
        }
    }

    partial class PartialClass
    {
        public string StringProperty3 { get; set; }
    }
}