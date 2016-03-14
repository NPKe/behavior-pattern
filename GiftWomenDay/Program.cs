using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftWomenDay
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gift> storeGift = new List<Gift>();

            storeGift.Add(new Gift("iPhone 6s", 20000, 75));
            storeGift.Add(new Gift("iPhone 5s", 10000, 80));
            storeGift.Add(new Gift("iPhone 4s", 4000, 30));
            storeGift.Add(new Gift("iPhone 3s", 2000, 20));

            storeGift.Add(new Gift("Honda AirBlade", 40000, 50));
            storeGift.Add(new Gift("Rose", 10, 100));
            storeGift.Add(new Gift("Watch", 5000, 80));

            Chooser chooser;

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                    chooser = new ChooseByPrice();
                else if (i == 1)
                    chooser = new ChooseByMinPay();
                else
                    chooser = new ChooseByName();

                chooser.ChooseGift(storeGift, 1000, "iPhone");
                chooser.PrintGift();
            }
        }
    }
}
