using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{
    class Property : IDisposable
    {
        public float Worth { get; set; }

        public Property(float worth)
        {
            Worth = worth;
        }

        public virtual float TaxCalculation()
        {
            return Worth;
        }

        public void Dispose()
        {
            Console.Beep();
        }
    }
}
