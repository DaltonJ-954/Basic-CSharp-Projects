using System;
using System.Collections.Generic;
using System.Text;

namespace MethodEX
{
    class Store
    {
        public int Clothes(int shirts, int pants = 12) { return shirts - pants; } // Default provided, second integer optional.
    }
}
