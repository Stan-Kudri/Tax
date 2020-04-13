using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax;

namespace Tax
{
    class CountryHouse : Property
    {
        public CountryHouse(float worth) : base(worth)
        {

        }

        public override float TaxCalculation()
        {
            try
            {
                return Worth / 500;
            }
            finally
            {                
            }
        }
    }
}
