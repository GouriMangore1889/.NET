using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp03_SOLID
{
        // Base interface
        public interface IDiscount
        {
            double GetDiscount(double amount);
        }

        // Existing discount
        public class RegularDiscount : IDiscount
        {
            public double GetDiscount(double amount)
            {
                return amount * 0.1;
            }
        }

        // New discount added WITHOUT modifying old code
        public class PremiumDiscount : IDiscount
        {
            public double GetDiscount(double amount)
            {
                return amount * 0.2;
            }
        }
    }


