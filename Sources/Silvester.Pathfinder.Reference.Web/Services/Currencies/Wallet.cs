using System.Collections.Generic;
using System.Text;

namespace Silvester.Pathfinder.Reference.Web.Services.Currencies
{
    public class Wallet
    {
        public int PlatinumCoins { get; set; }
        public int GoldCoins { get; set; }
        public int SilverCoins { get; set; }
        public int CopperCoins { get; set; }

        public Wallet(int platinumCoins, int goldCoins, int silverCoins, int copperCoins)
        {
            PlatinumCoins = platinumCoins;
            GoldCoins = goldCoins;
            SilverCoins = silverCoins;
            CopperCoins = copperCoins;
        }

        public bool IsEmpty()
        {
            return PlatinumCoins == 0 && GoldCoins == 0 && SilverCoins == 0 && CopperCoins == 0;
        }

        public override string ToString()
        {
            if(IsEmpty())
            {
                return "0";
            }

            return string.Join(" ", GetStringComponents());
        }

        private IEnumerable<string> GetStringComponents()
        {
            if (PlatinumCoins != 0)
            {
                yield return Coin.Format(PlatinumCoins, Coin.Types.Platinum);
            }

            if (GoldCoins != 0)
            {
                yield return Coin.Format(GoldCoins, Coin.Types.Gold);
            }

            if (SilverCoins != 0)
            {
                yield return Coin.Format(SilverCoins, Coin.Types.Silver);
            }

            if (CopperCoins != 0)
            {
                yield return Coin.Format(CopperCoins, Coin.Types.Copper);
            }
        }
    }
}
