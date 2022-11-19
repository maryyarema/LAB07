using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    interface ICar
    {
        string Model { get; }
        string Brakes { get; }
        string GasPedal { get; }
        string DriversName { get; set; }
    }
}