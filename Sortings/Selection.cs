namespace Sortings
{
    public static class Selection
    {
        public static void Sort<T>(T[] values, OrderType orderType = OrderType.Asc) where T : IComparable<T>
        {
            Validation.ValidateArray(values);

            switch (orderType)
            {
                case OrderType.Asc: LoopForAsc(values); break;
                case OrderType.Desc: LoopForDesc(values); break;
                default: throw new ArgumentException($"Invalid OrderType: {orderType}.");
            }
        }

        private static void LoopForAsc<T>(T[] values) where T : IComparable<T>
        {
            Validation.ValidateArray(values);

            if (IsSortedAsc(values))
                return;

            int smaller;
            T changer;

            for (int i = 0; i < values.Length; i++)
            {
                smaller = i;

                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j].CompareTo(values[smaller]) < 0)
                        smaller = j;
                }

                if (i != smaller)
                {
                    changer = values[i];
                    values[i] = values[smaller];
                    values[smaller] = changer;
                }
            }
        }

        private static void LoopForDesc<T>(T[] values) where T : IComparable<T>
        {
            Validation.ValidateArray(values);

            if (IsSortedDesc(values))
                return;

            int bigger;
            T changer;

            for (int i = 0; i < values.Length; i++)
            {
                bigger = i;

                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j].CompareTo(values[bigger]) > 0)
                        bigger = j;
                }

                if (i != bigger)
                {
                    changer = values[i];
                    values[i] = values[bigger];
                    values[bigger] = changer;
                }
            }
        }

        public static bool IsSorted<T>(T[] values, OrderType orderType = OrderType.Asc) where T : IComparable<T>
        {
            Validation.ValidateArray(values);

            return orderType switch
            {
                OrderType.Asc => IsSortedAsc(values),
                OrderType.Desc => IsSortedDesc(values),
                _ => throw new ArgumentException($"Invalid OrderType: {orderType}.")
            };
        }

        private static bool IsSortedAsc<T>(T[] values) where T : IComparable<T>
        {
            Validation.ValidateArray(values);

            int smaller;

            for (int i = 0; i < values.Length; i++)
            {
                smaller = i;

                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j].CompareTo(values[smaller]) < 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool IsSortedDesc<T>(T[] values) where T : IComparable<T>
        {
            Validation.ValidateArray(values);

            int bigger;

            for (int i = 0; i < values.Length; i++)
            {
                bigger = i;

                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j].CompareTo(values[bigger]) > 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
