namespace Sortings
{
    public static class Bubble<T> where T : IComparable<T>
    {
        public static void Sort(T[] values, OrderType orderType = OrderType.Asc)
        {
            ValidateArray(values);

            switch (orderType)
            {
                case OrderType.Asc: LoopForAsc(values); break;
                case OrderType.Desc: LoopForDesc(values); break;
                default: throw new ArgumentException($"Invalid OrderType: {orderType}.");
            }
        }

        private static void LoopForAsc(T[] values)
        {
            ValidateArray(values);

            if (IsSortedAsc(values))
                return;

            T changer;
            int numbersLength = values.Length;

            while (numbersLength > 0)
            {
                for (int i = 0; i < numbersLength - 1; i++)
                {
                    //Caso o valor seja maior deverá ir para outros índices
                    if (values[i].CompareTo(values[i + 1]) > 0)
                    {
                        changer = values[i];
                        values[i] = values[i + 1];
                        values[i + 1] = changer;
                    }
                }

                numbersLength--;
            }
        }

        private static void LoopForDesc(T[] values)
        {
            ValidateArray(values);

            if (IsSortedDesc(values))
                return;

            T changer;
            int numbersLength = values.Length;

            while (numbersLength > 0)
            {
                for (int i = 0; i < numbersLength - 1; i++)
                {
                    //Caso o valor seja menor deverá ir para outros índices
                    if (values[i].CompareTo(values[i + 1]) < 0)
                    {
                        changer = values[i];
                        values[i] = values[i + 1];
                        values[i + 1] = changer;
                    }
                }

                numbersLength--;
            }
        }

        public static bool IsSorted(T[] values, OrderType orderType = OrderType.Asc)
        {
            ValidateArray(values);

            return orderType switch
            {
                OrderType.Asc => IsSortedAsc(values),
                OrderType.Desc => IsSortedDesc(values),
                _ => throw new ArgumentException($"Invalid OrderType: {orderType}.")
            };
        }

        private static bool IsSortedAsc(T[] values)
        {
            ValidateArray(values);

            for (int i = 0; i < values.Length - 1; i++)
            {
                //Verifica se o array está em ordem ascendente
                if (values[i].CompareTo(values[i + 1]) > 0)
                    return false;
            }

            return true;
        }

        private static bool IsSortedDesc(T[] values)
        {
            ValidateArray(values);
            
            for (int i = 0; i < values.Length - 1; i++)
            {
                //Verifica se o array está em ordem descendente
                if (values[i].CompareTo(values[i + 1]) < 0)
                    return false;
            }

            return true;
        }
        
        private static void ValidateArray(T[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values), $"The {typeof(T)} array cannot be null.");

            if (!values.Any())
                throw new ArgumentException($"The {typeof(T)} array is empty.", nameof(values));
        }
    }
}
