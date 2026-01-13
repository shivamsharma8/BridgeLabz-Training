using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_scenario.ATMManager
{
    class NormalATM : ATM
    {
        public NormalATM() : base(new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 }) { }
    }

}
