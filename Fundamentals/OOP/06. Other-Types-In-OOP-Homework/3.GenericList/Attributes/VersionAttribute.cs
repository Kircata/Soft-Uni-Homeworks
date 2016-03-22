namespace _3.GenericList.Attributes
{
    using System;
    [AttributeUsage(AttributeTargets.Struct
        | AttributeTargets.Class
        | AttributeTargets.Interface
        | AttributeTargets.Enum
        | AttributeTargets.Method)]
    class VersionAttribute : Attribute
    {
        private int major;
        private int minor;
        private const string ShouldBePositive = "{0} should be positive or zero";

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Minor
        {
            get { return this.minor; }
            set
            {
                CheckIfNegative(value,"Minor");
                this.minor = value;
            }
        }

        public int Major
        {
            get { return this.major; }
            set
            {
                CheckIfNegative(value,"Major");
                this.major = value;
            }
        }

        private static void CheckIfNegative(int value, string type)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(type, string.Format(ShouldBePositive,type));
            }
        }
    }
}
