using System;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Web.Services.Currencies
{
    public interface ICurrencyService
    {
        Wallet Denormalize(int? copper, Coin.Types preferredType = Coin.Types.Gold);
        int Normalize(Wallet wallet);
        int Convert(int sourceAmount, Coin.Types sourceType, Coin.Types targetType, out int remainderAmount);
        int ConvertIfPreferred(int sourceAmount, Coin.Types sourceType, Coin.Types targetType, Coin.Types preferredType, out int remainderAmount);
    }

    public class CurrencyService : ICurrencyService
    {
        public Wallet Denormalize(int? copper, Coin.Types preferredType = Coin.Types.Gold)
        {
            return copper == null
                ? new Wallet(0, 0, 0, 0)
                : DenormalizeInternal(copper.Value, preferredType);
        }

        private Wallet DenormalizeInternal(int copper, Coin.Types preferredType = Coin.Types.Gold)
        {
            int platinum = ConvertIfPreferred(copper, Coin.Types.Copper, Coin.Types.Platinum, preferredType, out copper);
            int gold = ConvertIfPreferred(copper, Coin.Types.Copper, Coin.Types.Gold, preferredType, out copper);
            int silver = ConvertIfPreferred(copper, Coin.Types.Copper, Coin.Types.Silver, preferredType, out copper);

            return new Wallet(platinum, gold, silver, copper);
        }

        public int Normalize(Wallet wallet)
        {
            return Convert(wallet.CopperCoins, Coin.Types.Copper, Coin.Types.Copper, out int _)
                 + Convert(wallet.SilverCoins, Coin.Types.Silver, Coin.Types.Copper, out int _)
                 + Convert(wallet.GoldCoins, Coin.Types.Gold, Coin.Types.Copper, out int _)
                 + Convert(wallet.PlatinumCoins, Coin.Types.Platinum, Coin.Types.Copper, out int _);
        }

        public int ConvertIfPreferred(int sourceAmount, Coin.Types sourceType, Coin.Types targetType, Coin.Types preferredType, out int remainderAmount)
        {
            if (targetType != preferredType && Coin.IsHigher(targetType, preferredType))
            {
                remainderAmount = sourceAmount;
                return 0;
            }
            else
            {
                return Convert(sourceAmount, sourceType, targetType, out remainderAmount);
            }
        }

        public int Convert(int sourceAmount, Coin.Types sourceType, Coin.Types targetType, out int remainderAmount)
        {
            if (sourceType == targetType)
            {
                remainderAmount = 0;
                return sourceAmount;
            }

            double conversionRate = Coin.GetConversionRate(sourceType, targetType);

            if (conversionRate < 1)
            {
                remainderAmount = (int)(sourceAmount % (1d / conversionRate));
                return (int)Math.Floor(sourceAmount / (1d / conversionRate));
            }
            else
            {
                remainderAmount = 0;
                return (int)(sourceAmount * conversionRate);
            }
        }
    }
}
