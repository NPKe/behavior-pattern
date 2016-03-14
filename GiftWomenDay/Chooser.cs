using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftWomenDay
{
    public class Chooser
    {
        private List<Gift> AvailabeGift = new List<Gift>();

        public int ChooseGift(List<Gift> gift, float maxPay, string name)
        {
            for (int i = 0; i < gift.Count; i++)
            {
                if (isMatch(gift[i],maxPay,name))
                {
                    AvailabeGift.Add(gift[i]);
                }
            }

            return gift.Count;
        }

        protected virtual bool isMatch(Gift gift, float maxPay, string name)
        {
            return gift.Price <= maxPay;
        }

        public void PrintGift()
        {
            Console.WriteLine("Found: " + AvailabeGift.Count + " gift(s).");

            for (int i = 0; i < AvailabeGift.Count; i++)
            {
                Console.WriteLine("Name:\t" + AvailabeGift[i].Name);
                Console.WriteLine("Price:\t" + AvailabeGift[i].Price);
                Console.WriteLine("MinPay:\t" + AvailabeGift[i].MinPayPercent + "\n");
            }
        }
    }
}
