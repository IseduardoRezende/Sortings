namespace Sortings
{
    public static class Bubble<T> where T : IComparable<T>
    {
        public static void Sort(T[] values, OrderType orderType = OrderType.Asc)
        {
            if (values == null || !values.Any())
                return;

            switch (orderType)
            {
                case OrderType.Asc: LoopForAsc(values); break;
                case OrderType.Desc: LoopForDesc(values); break;
                default: return;
            }
        }

        public static bool IsSorted(T[] values, OrderType orderType = OrderType.Asc)
        {
            if (values is null || !values.Any())
                return false;

            return orderType switch
            {
                OrderType.Asc => IsSortedAsc(values),
                OrderType.Desc => IsSortedDesc(values),
                _ => false
            };
        }

        private static bool IsSortedAsc(T[] values)
        {
            if (values is null || !values.Any())
                return false;

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
            if (values is null || !values.Any())
                return false;

            for (int i = 0; i < values.Length - 1; i++)
            {
                //Verifica se o array está em ordem descendente
                if (values[i].CompareTo(values[i + 1]) < 0)
                    return false;
            }

            return true;
        }

        private static void LoopForAsc(T[] values)
        {
            if (values is null || !values.Any() || IsSortedAsc(values))
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
            if (values is null || !values.Any() || IsSortedDesc(values))
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
    }
}
