﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    interface IPhoneNumber
    {
        string[] Numbers { get; set; }
        void CallNumber(string[] strarray);
    }
}
