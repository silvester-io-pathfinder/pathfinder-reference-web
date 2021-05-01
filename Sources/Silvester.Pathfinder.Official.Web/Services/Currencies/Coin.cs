using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Web.Services.Currencies
{
    public class Coin
    {
        public enum Types
        {
            Copper,
            Silver,
            Gold,
            Platinum
        }

        public static IEnumerable<Types> GetCoinTypes()
        {
            yield return Types.Platinum;
            yield return Types.Gold;
            yield return Types.Silver;
            yield return Types.Copper;
        }

        public static IEnumerable<Types> GetCoinTypesDescending()
        {
            return GetCoinTypes().Reverse();
        }

        public static string Format(int amount, Types type)
        {
            return $"{amount} {GetAbbreviation(type)}";
        }

        public static string GetAbbreviation(Types type)
        {
            return type switch
            {
                Types.Copper => "cp",
                Types.Silver => "sp",
                Types.Gold => "gp",
                Types.Platinum => "pp",
                _ => throw new InvalidOperationException($"CoinType '{type}' not known.")
            };
        }

        public static bool IsHigher(Types self, Types other)
        {
            foreach (Types type in GetCoinTypes())
            {
                //If we encounter 'self' first, it must be bigger than 'other'.
                if (type == self)
                {
                    return true;
                }

                //If we encounter 'other' first, it must be bigger than 'self'.
                if (type == other)
                {
                    return false;
                }
            }

            throw new InvalidOperationException("This should never be reached.");
        }

        public static double GetConversionRate(Types sourceType, Types targetType)
        {
            return sourceType switch
            {
                Types.Copper => targetType switch
                {
                    Types.Copper => 1d,
                    Types.Silver => 0.1d,
                    Types.Gold => 0.01,
                    Types.Platinum => 0.001,
                    _ => throw new InvalidOperationException($"CoinType '{targetType}' not known.")
                },
                Types.Silver => targetType switch
                {
                    Types.Copper => 10d,
                    Types.Silver => 1d,
                    Types.Gold => 0.1d,
                    Types.Platinum => 0.01,
                    _ => throw new InvalidOperationException($"CoinType '{targetType}' not known.")
                },
                Types.Gold => targetType switch
                {
                    Types.Copper => 100d,
                    Types.Silver => 10d,
                    Types.Gold => 1d,
                    Types.Platinum => 0.1d,
                    _ => throw new InvalidOperationException($"CoinType '{targetType}' not known.")
                },
                Types.Platinum => targetType switch
                {
                    Types.Copper => 1000d,
                    Types.Silver => 100d,
                    Types.Gold => 10d,
                    Types.Platinum => 1d,
                    _ => throw new InvalidOperationException($"CoinType '{targetType}' not known.")
                },
                _ => throw new InvalidOperationException($"CoinType '{sourceType}' not known.")
            };
        }
    }
}
