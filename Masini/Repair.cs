using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masini
{
    class Repair
    {
        string VIN;
        string Description;
        float Cost;

        public Repair(string _VIN, string _Description, float _Cost)
        {
            VIN = _VIN;
            Description = _Description;
            Cost = _Cost;

        }
    }
}
