namespace ReSharper20173CSharp.Deconstructors
{
    public class Version
    {
        public int Major { get; }
        public int Minor { get; }
        public int Patch { get; }

        /// <inheritdoc />
        public Version(int major, int minor, int patch)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
        }

        // Alt+Insert, Deconstructor, add deconstructor for select properties

        /// <inheritdoc />
        public override string ToString()
        {
            return $"{Major}.{Minor}.{Patch}";
        }
    }
}
