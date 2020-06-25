using System;

namespace NCoreProjects.Extensions
{
    public static class StringExtension


    {
        public static bool IsNull(this string value)
        {
            return value == null;
        }

        public static bool IsNullOrEmpty(this string value)
        {
                        return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool SafeEquals(this string source, string destination, StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
        {
            if (source == null && destination == null) return true;

            if (source == null) return false;

            if (destination == null) return false;

            return source.Equals(destination, stringComparison);

        }

        public static void ShouldNotBeNull<T>(this T source, string paramName) where T :class
        {
            if (source == null)
                throw new ArgumentNullException(paramName);
        }
    }
}
