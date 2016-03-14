using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftWomenDay
{
    class ChooseByMinPay : Chooser
    {
        protected override bool isMatch(Gift gift, float maxPay, string name)
        {
            return gift.MinPayPercent / 100 * gift.Price <= maxPay;
        }
    }
}
