using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax;

namespace Tax
{
    class Apparment:Property
    {
        public Apparment(float worth) : base(worth)
        {

        }

        public override float TaxCalculation()
        {
            try
            {
                return Worth / 1000;
            }
            finally
            {                
            }
        }
    }
}
