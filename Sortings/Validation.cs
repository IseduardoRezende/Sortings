namespace Sortings
{
    public static class Validation
    {
        public static void ValidateArray<T>(T[] values) where T : IComparable<T>
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values), $"The {typeof(T)} array cannot be null.");

            if (!values.Any())
                throw new ArgumentException($"The {typeof(T)} array is empty.", nameof(values));
        }
    }
}
