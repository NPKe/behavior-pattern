using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftWomenDay
{
    class ChooseByPrice : Chooser
    {
        protected override bool isMatch(Gift gift, float maxPay, string name)
        {
            return gift.Price <= maxPay;
        }
    }
}
