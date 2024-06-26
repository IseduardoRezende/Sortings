﻿namespace Sortings
{
    public static class Bubble
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

        private static void LoopForDesc<T>(T[] values) where T : IComparable<T>
        {
            Validation.ValidateArray(values);

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

            for (int i = 0; i < values.Length - 1; i++)
            {
                //Verifica se o array está em ordem ascendente
                if (values[i].CompareTo(values[i + 1]) > 0)
                    return false;
            }

            return true;
        }

        private static bool IsSortedDesc<T>(T[] values) where T : IComparable<T>
        {
            Validation.ValidateArray(values);
            
            for (int i = 0; i < values.Length - 1; i++)
            {
                //Verifica se o array está em ordem descendente
                if (values[i].CompareTo(values[i + 1]) < 0)
                    return false;
            }

            return true;
        }              
    }
}
