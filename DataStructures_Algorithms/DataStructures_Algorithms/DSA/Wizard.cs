using System;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    public class Wizard
    {
        Stack ts = new Stack();

        public string Name { get; set; }
        public int Exp { get; set; }

        public bool IsWizard()
        {
            return true;
        }
    }
}
