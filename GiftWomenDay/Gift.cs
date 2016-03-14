using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftWomenDay
{
    public class Gift
    {
        public string Name
        {
            get;
            set;
        }

        public float Price
        {
            get;
            set;
        }

        public float MinPayPercent
        {
            get;
            set;
        }

        public Gift(string name, float price, float minPayPercent)
        {
            Name = name;
            Price = price;
            MinPayPercent = minPayPercent;
        }
    }
}
