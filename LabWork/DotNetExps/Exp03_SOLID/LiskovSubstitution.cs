using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp03_SOLID
{
    
        // Base class
        public class Bird
        {
            public virtual string Move()
            {
                return "Bird is moving";
            }
        }

        // Child class
        public class Sparrow : Bird
        {
            public override string Move()
            {
                return "Sparrow is flying";
            }
        }
    }


